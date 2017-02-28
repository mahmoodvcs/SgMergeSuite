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
        private ITfsWrapper _tfsServer;
        public ITfsWrapper TfsServer
        {
            get { return _tfsServer; }
            set
            {
                _tfsServer = value;
                SetControlStates();
            }
        }

        private List<ChangesetView> mergeCandidates;

        public frmMain()
        {
            InitializeComponent();
            if (TfsServer == null)
                tsmiOptions_Click(null, null);
            SetMergeCandidateButtonState();
            SetControlStates();
        }


        private void btnGetMergeCandidates_Click(object sender, EventArgs e)
        {
            RefreshMergeCandidates();
        }


		private void btnGetSelected_Click(object sender, EventArgs e)
		{
			if (TfsServer.PendingChangesCount() > 0)
			{
				MessageBox.Show(
					"You have pending changes in your local copy. Check them in or shelve them to proceed.",
					"Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				return;
			}
			var result = MessageBox.Show(
				"Always make sure that you have the latest version on both branches (source & target).",
				"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			if (result != DialogResult.OK)
				return;
			var selectedChangesetIds = GetSelectedChangesetIds();
			var selectedChangesets = mergeCandidates.Where(m => selectedChangesetIds.Contains(m.ChangesetId)).ToList().ToList();
			var frmMerge = new frmMerge(TfsServer, selectedChangesets, GetSourceBranch(), GetTargetBranch());
			frmMerge.ShowDialog();
			RefreshMergeCandidates();
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
            var chageset = TfsServer.GetChangesetDetail(changesetId);

            txtWorkItemDetails.Text = string.Join("\r\n", chageset.WorkItems);
            txtChangesetDetails.Text = string.Join("\r\n", chageset.Changes);
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
            tsmiGetMergeCandidates.Enabled = btnGetMergeCandidates.Enabled = !string.IsNullOrEmpty(GetSourceBranch()) &&
                                            !string.IsNullOrEmpty(GetTargetBranch());
            tsmiMergeSelectedItems.Enabled = btnMergeSelectedItems.Enabled = grdMergeCandidates.SelectedRows.Count > 0 && btnGetMergeCandidates.Enabled;
        }

        private void RefreshMergeCandidates()
        {
            this.Enabled = false;
            changesetViewBindingSource.Clear();
            mergeCandidates = TfsServer.GetMergeCandidates(GetSourceBranch(), GetTargetBranch());
            changesetViewBindingSource.DataSource = mergeCandidates;
            tsslMergeCandidates.Text = "Merge Candidates: " + grdMergeCandidates.RowCount;
            this.Enabled = true;
        }
        #endregion

        private void tsmiOptions_Click(object sender, EventArgs e)
        {
            try
            {
                var frmOptions = new frmOptions(TfsServer == null);
                var result = frmOptions.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TfsServer = null;
                    tsmiConnect_Click(null, null);
                    SetControlStates();
                }
                frmOptions.Dispose();
                LoadConfig();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CreateBranchTrees()
        {
            CreateBranchTrees(uxSourceBranch.Nodes, TfsServer.Branches);
            //CreateBranchTrees(uxTargetBranch.Nodes, TfsServer.Branches);
        }

        private void CreateBranchTrees(ComboTreeNodeCollection nodes, List<BranchInfo> brs)
        {
            nodes.Clear();
            foreach (var br in brs)
            {
                var n = nodes.Add(br.Name);
                n.Tag = br;
                CreateBranchTrees(n.Nodes, br.ChildBranches);
            }
        }

        private void tsmiConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var strWorkspaceName = string.IsNullOrEmpty(ConfigHelper.WorkspaceName) ?
                Environment.MachineName :
                ConfigHelper.WorkspaceName;
                var strWorkspaceOwner = string.IsNullOrEmpty(ConfigHelper.WorkspaceOwner) ?
                    Environment.UserName :
                    ConfigHelper.WorkspaceOwner;
                TfsServer = new TfsWrapper(ConfigHelper.VertionControlServerPath, strWorkspaceName, strWorkspaceOwner);
                CreateBranchTrees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void LoadConfig()
        {
            if (!string.IsNullOrEmpty(ConfigHelper.SourceBranch))
                uxSourceBranch.SelectedNode = uxSourceBranch.GetNodeAt(ConfigHelper.SourceBranch.Remove(0, 2));
            if (!string.IsNullOrEmpty(ConfigHelper.TargetBranch))
                try
                {
                    uxTargetBranch.SelectedNode = uxTargetBranch.GetNodeAt(ConfigHelper.TargetBranch.Remove(0, 2));
                }
                catch { }
        }

        private void SetControlStates()
        {
            grdMergeCandidates.Enabled = grboxBranchInfo.Enabled = TfsServer != null;
        }

        private void uxSourceBranch_SelectedNodeChanged(object sender, EventArgs e)
        {
            ConfigHelper.SourceBranch = GetSourceBranch();
            FillTargetBrachItems();
        }
        private void uxTargetBranch_SelectedNodeChanged(object sender, EventArgs e)
        {
            ConfigHelper.TargetBranch = GetTargetBranch();
            UpdateMergePath();
        }

        string GetSourceBranch(bool addRootSign = true)
        {
            return uxSourceBranch.SelectedNode == null ? "" : (addRootSign ? "$/" : "") + uxSourceBranch.SelectedNode.GetFullPath("/", false);
        }
        string GetTargetBranch()
        {
            return uxTargetBranch.SelectedNode == null ? "" : "$/" + uxTargetBranch.SelectedNode.GetFullPath("/", false);
        }

        private void uxAllowMultiLevelMerge_CheckedChanged(object sender, EventArgs e)
        {
            FillTargetBrachItems();
        }

        private void FillTargetBrachItems()
        {
            var source = TfsServer.FindBranch(GetSourceBranch());
            //var branches = TfsServer.GetAllowedMergeBranches(source, uxAllowMultiLevelMerge.Checked);
            uxTargetBranch.Nodes.Clear();
            if (source == null)
            {
                uxTargetBranch.Enabled = false;
                return;
            }
            uxTargetBranch.Enabled = true;
            if (!uxAllowMultiLevelMerge.Checked)
            {
                foreach (var br in source.ChildBranches)
                {
                    var n = uxTargetBranch.Nodes.Add(br.Name.Remove(0, 2));
                    n.Tag = br;
                }
                if (source.Parent != null)
                {
                    var n = uxTargetBranch.Nodes.Add(source.Parent.Name.Remove(0, 2));
                    n.Tag = source.Parent;
                }
                uxTargetBranch.SelectedNode = uxTargetBranch.Nodes[0];
            }
            else
            {
                var l = new List<Code.Wrappers.BranchInfo>();
                l.Add(TfsServer.Branches.Single(b => GetSourceBranch(false).StartsWith(b.Name)));
                CreateBranchTrees(uxTargetBranch.Nodes, l);
                uxTargetBranch.SelectedNode = uxTargetBranch.GetNodeAt((source.Parent ?? source.ChildBranches[0]).Name.Remove(0, 2));
            }
        }

        private void UpdateMergePath()
        {
            var path = TfsServer.GetPath(GetSourceBranch(), GetTargetBranch());
            if (path == null)
            {
                uxMergePath.Text = "";
                btnGetMergeCandidates.Enabled = false;
                return;
            }
            btnGetMergeCandidates.Enabled = true;
            uxMergePath.Text = string.Join(" -->> ", path.Select(p => p.Name.Remove(0, 2)));
        }
    }
}
