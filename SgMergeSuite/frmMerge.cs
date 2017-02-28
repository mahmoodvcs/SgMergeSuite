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
        protected ITfsWrapper TfsServer;
        protected readonly IList<ChangesetView> MainChangesets;
        protected IList<ChangesetView> Changesets;
        protected readonly string SourceBranch;
        protected readonly string TargetBranch;
        protected bool isStarted;
        enum enumNOCIPosition
        {
            NoChange = 0,
            AddNOCIchanges = 1,
            RemoveNOCI = 2,
            AfterAllChangesets,
            BeforeAllChangesets,
            AfterAllChangesetsExpectTheLast,
            BeforeAllChangesetsExpectTheLast
        }
        public frmMerge(ITfsWrapper tfsWrapper, IList<ChangesetView> changesets, string sourceBranch, string targetBranch)
        {
            MainChangesets = changesets.Clone();
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
                if (
                    MessageBox.Show("Are you sure you start Merges?", "Final Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnStop.Enabled = true;
                    grboxMergeInfo.Enabled = btnStart.Enabled = false;
                    btnApply.Enabled = false;
                    isStarted = true;
                    Changesets = MainChangesets.Clone();
                    var unprocessedChangesets = Changesets.Where(c => !c.HasProcessed).ToList();
                    prgProgressbar.Value = 0;
                    MergeAndCheckinChangesetsAsync(unprocessedChangesets);
                }
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

        private enumNOCIPosition getNOCIPostion()
        {
            enumNOCIPosition NOCIPostion = (enumNOCIPosition)cbNoCIState.SelectedIndex;
            if (NOCIPostion == enumNOCIPosition.AddNOCIchanges)
            {
                NOCIPostion = (enumNOCIPosition)(cbNOCIPosition.SelectedIndex + 3);
            }
            return NOCIPostion;
        }

        private async void MergeAndCheckinChangesetsAsync(List<ChangesetView> changesets)
        {
            mergeItemViewBindingSource.Clear();
            var index = 0;
            var totalChangesetCount = changesets.Count;
            var includeWorkItems = chkIncludeWorkItems.Checked;
            var RemoveStrings = txtRemoveStrings.Text.Split('\n').ToList();
            enumNOCIPosition NOCIPostion = getNOCIPostion();
            while (isStarted && index < totalChangesetCount)
            {
                var changeset = changesets[index];
                changeset.Comment = ResolveComment(changeset.Comment, RemoveStrings, NOCIPostion, txtCommentPrefix.Text, txtFindWhat.Text, txtReplaceWith.Text, (index + 1) == totalChangesetCount);
                MergeItemView mergeItem = await Task.Run(() => MergeChangeSet(changeset));
                if (!mergeItem.IsSuccessfull)
                {
                    mergeItemViewBindingSource.Add(mergeItem);
                    MessageBox.Show(string.Format("There were {0} conflicts merging changeset #{1}, resolve these conflicts/failures and try again....", mergeItem.NumConflicts, mergeItem.ChangesetId), "Conflicts/Failures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnStop.Enabled = btnStart.Enabled = false;
					new TfsPowerToolsWrapper(TfsServer.WorkspaceName).Resolve();
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
                btnStart.Enabled = btnStop.Enabled = false;
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
            var workitems = includeWorkItems ? changeset.WorkItems.Select(w => new WorkItemCheckinInfo(w.Obj, WorkItemCheckinAction.Associate)).ToArray() : new WorkItemCheckinInfo[] { };
            TfsServer.CheckInPendingChangesets(mergeItem.Comment, changeset.CheckinNote, workitems, changeset.PolicyOverrideInfo);
        }

        private MergeItemView MergeChangeSet(ChangesetView changeset)
        {
            var stat = TfsServer.MergeChangeset(SourceBranch, TargetBranch, changeset.ChangesetId);
            var mergeItem = new MergeItemView()
            {
                ChangesetId = changeset.ChangesetId,
                Comment = changeset.Comment,
                NumConflicts = stat.NumConflicts,
                NumFailures = stat.NumFailures
            };
            changeset.HasProcessed = true;
            return mergeItem;
        }

        private string ResolveComment(string comment, List<string> removeStrings, enumNOCIPosition NOCIPostion = enumNOCIPosition.NoChange, string prefix = "", string strFindWhat = "", string strReplaceWith = "", bool isLastChangeset = false)
        {
            const string noci = "***NO_CI***";
            if (prefix.Length > 0)
                removeStrings.Add(prefix);
            foreach (var removeString in removeStrings)
            {
                if (removeString.Length > 0)
                    comment = comment.Replace(removeString.Replace("\r", string.Empty), string.Empty);
            }
            comment = comment.Trim();
            if (!string.IsNullOrEmpty(strFindWhat) || !string.IsNullOrEmpty(strReplaceWith))
                comment = comment.Replace(strFindWhat, strReplaceWith);
            switch (NOCIPostion)
            {
                case enumNOCIPosition.NoChange:
                case enumNOCIPosition.AddNOCIchanges:
                    break;
                case enumNOCIPosition.RemoveNOCI:
                    comment = comment.Replace(noci, "").Trim();
                    break;
                case enumNOCIPosition.AfterAllChangesets:
                    comment = comment.Replace(noci, "").Trim();
                    comment = comment + " " + noci;
                    break;
                case enumNOCIPosition.BeforeAllChangesets:
                    comment = comment.Replace(noci, "").Trim();
                    comment = noci + " " + comment;
                    break;
                case enumNOCIPosition.AfterAllChangesetsExpectTheLast:
                    if (!isLastChangeset)
                    {
                        comment = comment.Replace(noci, "").Trim();
                        comment = comment + " " + noci;
                    }
                    break;
                case enumNOCIPosition.BeforeAllChangesetsExpectTheLast:
                    if (!isLastChangeset)
                    {
                        comment = comment.Replace(noci, "").Trim();
                        comment = noci + " " + comment;
                    }
                    break;
                default:
                    break;
            }
            if (comment.StartsWith(noci))
            {
                comment = comment.Replace(noci, noci + " " + prefix);
            }
            else
            {
                comment = prefix + comment;
            }
            return comment;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNOCIPosition.Enabled = cbNoCIState.SelectedIndex == (int)enumNOCIPosition.AddNOCIchanges;
        }
        private async void ShowChangeSetsPreview(List<ChangesetView> changesets)
        {
            mergeItemViewBindingSource.Clear();
            var index = 0;
            var totalChangesetCount = changesets.Count;
            var removeStrings = txtRemoveStrings.Text.Split('\n').ToList();
            enumNOCIPosition NOCIPostion = getNOCIPostion();
            while (isStarted && index < totalChangesetCount)
            {
                var changeset = changesets[index];
                changeset.Comment = ResolveComment(changeset.Comment, removeStrings, NOCIPostion, txtCommentPrefix.Text, txtFindWhat.Text, txtReplaceWith.Text, (index + 1) == totalChangesetCount);
                MergeItemView mergeItem = await Task.Run(() => GetChangeSetPreview(changeset));
                mergeItemViewBindingSource.Add(mergeItem);
                grdMergedItems.FirstDisplayedScrollingRowIndex = grdMergedItems.RowCount - 1;
                index++;
                prgProgressbar.Value = index * 100 / totalChangesetCount;
            }
            isStarted = false;
        }
        private MergeItemView GetChangeSetPreview(ChangesetView changeset)
        {
            var mergeItem = new MergeItemView()
            {
                ChangesetId = changeset.ChangesetId,
                Comment = changeset.Comment,
                NumConflicts = 0,
                NumFailures = 0
            };
            return mergeItem;
        }

        private void grdMergedItems_Click(object sender, EventArgs e)
        {
            if (grdMergedItems.CurrentCell != null && grdMergedItems.CurrentCell.ColumnIndex == 2)
            {
                DataGridViewCell cell = grdMergedItems.CurrentCell;
                grdMergedItems.CurrentCell = cell;
                grdMergedItems.BeginEdit(true);
            }
        }
        private void grdMergedItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (grdMergedItems.CurrentCell != null && (e.KeyCode != Keys.Tab && grdMergedItems.CurrentCell.ColumnIndex == 2))
            {
                e.Handled = false;
                DataGridViewCell cell = grdMergedItems.CurrentCell;
                grdMergedItems.CurrentCell = cell;
                grdMergedItems.BeginEdit(true);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                btnStop.Enabled = true;
                grboxMergeInfo.Enabled = btnStart.Enabled = false;
                isStarted = true;
                Changesets = MainChangesets.Clone();
                var unprocessedChangesets = Changesets.Where(c => !c.HasProcessed).ToList();
                prgProgressbar.Value = 0;
                ShowChangeSetsPreview(unprocessedChangesets);
                grboxMergeInfo.Enabled = btnApply.Enabled = btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }
    }
}
