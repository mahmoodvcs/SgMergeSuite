using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SgMergeSuite.Code.Helpers;
using SgMergeSuite.Code.ModelViews;
using SgMergeSuite.Code.Wrappers;

namespace SgMergeSuite
{
    public partial class frmMain : Form
    {
        protected TfsWrapper TfsServer;
        private List<ChangesetView> mergeCandidates; 
        public frmMain()
        {
            InitializeComponent();
            txtTargetBranch.Text = ConfigHelper.TargetBranch;
            txtSourceBranch.Text = ConfigHelper.SourceBranch;
            this.txtTargetBranch.TextChanged += new System.EventHandler(this.txtBranch_TextChanged);
            this.txtSourceBranch.TextChanged += new System.EventHandler(this.txtBranch_TextChanged);
            SetMergeCandidateButtonState();
            SetControlStates();
        }


        private void btnGetMergeCandidates_Click(object sender, EventArgs e)
        {
            RefreshMergeCandidates();
        }


        private void btnGetSelected_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "Always make sure that you have the latest version on both branches (source & target) and you have no pending changes waiting to be checked in.",
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                var selectedChangesetIds = GetSelectedChangesetIds();
                var selectedChangesets = mergeCandidates.Where(m => selectedChangesetIds.Contains(m.ChangesetId)).ToList().Clone().ToList();
                var frmMerge = new frmMerge(TfsServer, selectedChangesets, txtSourceBranch.Text, txtTargetBranch.Text);
                frmMerge.ShowDialog();
                RefreshMergeCandidates();
            }
        }

        private void grdMergeCandidates_SelectionChanged(object sender, EventArgs e)
        {
            tsslSelectedItems.Text = "Selected Items: " + grdMergeCandidates.SelectedRows.Count;
            tsmiMergeSelectedItems.Enabled = btnMergeSelectedItems.Enabled = grdMergeCandidates.SelectedRows.Count > 0;
            if (grdMergeCandidates.SelectedRows.Count != 1)
            {
                txtWorkItemDetails.Text = "";
                txtChangesetDetails.Text = "";
                return;
            }
            var changesetId = GetSelectedChangesetIds().First();
            var chageset=  TfsServer.GetChangesetDetail(changesetId);

            txtWorkItemDetails.Text = string.Join("\r\n", chageset.WorkItems);
            txtChangesetDetails.Text = string.Join("\r\n", chageset.Changes);
        }

        private void txtBranch_TextChanged(object sender, EventArgs e)
        {
            ConfigHelper.SourceBranch = txtSourceBranch.Text;
            ConfigHelper.TargetBranch = txtTargetBranch.Text;
            SetMergeCandidateButtonState();
        }


        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        #region Private Memebers

        public List<int> GetSelectedChangesetIds()
        {
            var changesets = new List<int>();
            var count = grdMergeCandidates.SelectedRows.Count;
            for (int i = 0; i < count; i++)
            {
                changesets.Add(Convert.ToInt32(grdMergeCandidates.SelectedRows[i].Cells[0].Value));
            }
            return changesets;
        }

        private void SetMergeCandidateButtonState()
        {
            tsmiGetMergeCandidates.Enabled = btnGetMergeCandidates.Enabled = !string.IsNullOrEmpty(txtSourceBranch.Text) &&
                                            !string.IsNullOrEmpty(txtTargetBranch.Text);
            tsmiMergeSelectedItems.Enabled = btnMergeSelectedItems.Enabled =grdMergeCandidates.SelectedRows.Count > 0 && btnGetMergeCandidates.Enabled;
        }

        private void RefreshMergeCandidates()
        {
            this.Enabled = false;
            changesetViewBindingSource.Clear();
            mergeCandidates = TfsServer.GetMergeCandidates(txtSourceBranch.Text, txtTargetBranch.Text);
            changesetViewBindingSource.DataSource = mergeCandidates;
            tsslMergeCandidates.Text = "Merge Candidates: " + grdMergeCandidates.RowCount;
            this.Enabled = true;
        }
        #endregion

        private void tsmiOptions_Click(object sender, EventArgs e)
        {
            var frmOptions = new frmOptions();
            var result =  frmOptions.ShowDialog();
            if (result == DialogResult.OK)
            {
                TfsServer = null;
                SetControlStates();
            }
            frmOptions.Dispose();
        }

        private void tsmiConnect_Click(object sender, EventArgs e)
        {
            try
            {
                TfsServer = new TfsWrapper(ConfigHelper.VertionControlServerPath, ConfigHelper.WorkspaceName, ConfigHelper.WorkspaceOwner);
                SetControlStates();

            }
            catch
            {
                MessageBox.Show("Could not connect to TFS Source Control Server.\nCheck your application settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetControlStates()
        {
            grdMergeCandidates.Enabled = grboxBranchInfo.Enabled = TfsServer != null;
        }

    }
}
