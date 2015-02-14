using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SgMergeSuite.Code.ModelViews;
using SgMergeSuite.Code.Wrappers;
using SgMergeSuite.Code.Helpers;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace SgMergeSuite
{
    public partial class frmMerge : Form
    {
        protected TfsWrapper TfsServer;
        protected readonly List<ChangesetView> Changesets;
        protected readonly string SourceBranch;
        protected readonly string TargetBranch;
        protected bool isStarted;
        public frmMerge(TfsWrapper tfsWrapper, List<ChangesetView> changesets, string sourceBranch, string targetBranch)
        {
            Changesets = changesets;
            SourceBranch = sourceBranch;
            TargetBranch = targetBranch;
            TfsServer = tfsWrapper;
            InitializeComponent();

            InitializeControlsData(sourceBranch, targetBranch);
        }

        private void InitializeControlsData(string sourceBranch, string targetBranch)
        {
            lblSourceBranch.Text = sourceBranch;
            lblTargetBranch.Text = targetBranch;
            lblTotalChangesetCount.Text = Changesets.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                btnStop.Enabled = true;
                grboxMergeInfo.Enabled =  btnStart.Enabled = false;
                isStarted = true;
                var unprocessedChangesets = Changesets.Where(c => !c.HasProcessed).ToList();
                prgProgressbar.Value = 0;
                MergeAndCheckinChangesetsAsync(unprocessedChangesets);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                isStarted = false;
                btnStop.Enabled = false;
                grboxMergeInfo.Enabled = btnStart.Enabled = true;
            }
        }

        private async void MergeAndCheckinChangesetsAsync(List<ChangesetView> changesets)
        {
            var index = 0;
            var totalChangesetCount = changesets.Count;
            var includeWorkItems = chkIncludeWorkItems.Checked;
            while (isStarted && index < totalChangesetCount)
            {
                var changeset = changesets[index];
                changeset.Comment = ResolveComment(changeset.Comment, txtCommentPrefix.Text, (index + 1) < totalChangesetCount);
                MergeItemView mergeItem = await Task.Run(() => MergeChangeSet(changeset));
                if (!mergeItem.IsSuccessfull)
                {
                    mergeItemViewBindingSource.Add(mergeItem);
                    MessageBox.Show(string.Format("There were {0} conflicts merging changeset #{1}, resolve these conflicts/failures and try again....", mergeItem.NumConflicts, mergeItem.ChangesetId), "Conflicts/Failures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnStop.Enabled = btnStart.Enabled = false;
                    return;
                }
                await Task.Run(() => CheckInPendingChanges(mergeItem, includeWorkItems));
                mergeItemViewBindingSource.Add(mergeItem);
                grdMergedItems.FirstDisplayedScrollingRowIndex = grdMergedItems.RowCount - 1;
                index++;
                prgProgressbar.Value = index * 100 / totalChangesetCount;
            }
            if (index == totalChangesetCount)
            {
                MessageBox.Show("All changesets merged successfully.");
                btnStart.Enabled =btnStop.Enabled = false;
            }
            else
            {
                MessageBox.Show("Operation stoped by user.");
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void CheckInPendingChanges(MergeItemView mergeItem, bool includeWorkItems)
        {
            var changeset = TfsServer.GetChangesetDetail(mergeItem.ChangesetId);
            var workitems = includeWorkItems ? changeset.WorkItems.Select(w => new WorkItemCheckinInfo(w.Obj, WorkItemCheckinAction.Associate)).ToArray() : new WorkItemCheckinInfo[]{};
            TfsServer.CheckInPendingChangesets(mergeItem.Comment, changeset.CheckinNote, workitems, changeset.PolicyOverrideInfo);
        }

        private MergeItemView MergeChangeSet(ChangesetView changeset)
        {
            var stat = TfsServer.MergeChangeset(SourceBranch, TargetBranch, changeset.ChangesetId);
            var mergeItem =  new MergeItemView()
            {
                ChangesetId = changeset.ChangesetId,
                Comment = changeset.Comment,
                NumConflicts =  stat.NumConflicts,
                NumFailures =  stat.NumFailures
            };
            changeset.HasProcessed = true;
            return  mergeItem;
        }

        private string ResolveComment(string comment, string prefix = "", bool addNoCi = true)
        {
            const string noci = "***NO_CI***";
            comment = comment.Trim();
            if (comment.StartsWith(noci))
            {
                comment = comment.Replace(noci, noci + " " + prefix);
            }
            else
            {
                comment = noci + " " + prefix + comment;
            }
            if (!addNoCi){
                comment = comment.Replace(noci,"");
            }
            return comment;
        }

    }
}
