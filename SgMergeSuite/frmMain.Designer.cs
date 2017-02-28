namespace SgMergeSuite
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnGetMergeCandidates = new System.Windows.Forms.Button();
			this.grdMergeCandidates = new System.Windows.Forms.DataGridView();
			this.changesetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.changesetViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnMergeSelectedItems = new System.Windows.Forms.Button();
			this.grboxBranchInfo = new System.Windows.Forms.GroupBox();
			this.uxAllowMultiLevelMerge = new System.Windows.Forms.CheckBox();
			this.uxTargetBranch = new ComboTreeBox();
			this.uxSourceBranch = new ComboTreeBox();
			this.lblTargetbranch = new System.Windows.Forms.Label();
			this.lblSource = new System.Windows.Forms.Label();
			this.grboxChangeSetInfo = new System.Windows.Forms.GroupBox();
			this.lblWorkitemDetails = new System.Windows.Forms.Label();
			this.lblChangesetDetails = new System.Windows.Forms.Label();
			this.txtWorkItemDetails = new System.Windows.Forms.TextBox();
			this.txtChangesetDetails = new System.Windows.Forms.TextBox();
			this.tsmMenu = new System.Windows.Forms.MenuStrip();
			this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiGetMergeCandidates = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMergeSelectedItems = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmTools = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tsslMergeCandidates = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslSelectedItems = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.uxMergePath = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grdMergeCandidates)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.changesetViewBindingSource)).BeginInit();
			this.grboxBranchInfo.SuspendLayout();
			this.grboxChangeSetInfo.SuspendLayout();
			this.tsmMenu.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGetMergeCandidates
			// 
			this.btnGetMergeCandidates.ForeColor = System.Drawing.Color.ForestGreen;
			this.btnGetMergeCandidates.Location = new System.Drawing.Point(20, 103);
			this.btnGetMergeCandidates.Name = "btnGetMergeCandidates";
			this.btnGetMergeCandidates.Size = new System.Drawing.Size(234, 35);
			this.btnGetMergeCandidates.TabIndex = 0;
			this.btnGetMergeCandidates.Text = "Get Merge Candidates";
			this.btnGetMergeCandidates.UseVisualStyleBackColor = true;
			this.btnGetMergeCandidates.Click += new System.EventHandler(this.btnGetMergeCandidates_Click);
			// 
			// grdMergeCandidates
			// 
			this.grdMergeCandidates.AllowUserToAddRows = false;
			this.grdMergeCandidates.AllowUserToDeleteRows = false;
			this.grdMergeCandidates.AllowUserToOrderColumns = true;
			this.grdMergeCandidates.AllowUserToResizeRows = false;
			this.grdMergeCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdMergeCandidates.AutoGenerateColumns = false;
			this.grdMergeCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMergeCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changesetIdDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
			this.grdMergeCandidates.DataSource = this.changesetViewBindingSource;
			this.grdMergeCandidates.Location = new System.Drawing.Point(12, 227);
			this.grdMergeCandidates.Name = "grdMergeCandidates";
			this.grdMergeCandidates.ReadOnly = true;
			this.grdMergeCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdMergeCandidates.Size = new System.Drawing.Size(809, 240);
			this.grdMergeCandidates.TabIndex = 1;
			this.grdMergeCandidates.SelectionChanged += new System.EventHandler(this.grdMergeCandidates_SelectionChanged);
			// 
			// changesetIdDataGridViewTextBoxColumn
			// 
			this.changesetIdDataGridViewTextBoxColumn.DataPropertyName = "ChangesetId";
			this.changesetIdDataGridViewTextBoxColumn.HeaderText = "Changeset";
			this.changesetIdDataGridViewTextBoxColumn.Name = "changesetIdDataGridViewTextBoxColumn";
			this.changesetIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.changesetIdDataGridViewTextBoxColumn.Width = 80;
			// 
			// userDataGridViewTextBoxColumn
			// 
			this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
			this.userDataGridViewTextBoxColumn.HeaderText = "User";
			this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
			this.userDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 120;
			// 
			// commentDataGridViewTextBoxColumn
			// 
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			this.commentDataGridViewTextBoxColumn.ReadOnly = true;
			this.commentDataGridViewTextBoxColumn.Width = 400;
			// 
			// changesetViewBindingSource
			// 
			this.changesetViewBindingSource.DataSource = typeof(SgMergeSuite.Code.ModelViews.ChangesetView);
			// 
			// btnMergeSelectedItems
			// 
			this.btnMergeSelectedItems.Enabled = false;
			this.btnMergeSelectedItems.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnMergeSelectedItems.Location = new System.Drawing.Point(20, 144);
			this.btnMergeSelectedItems.Name = "btnMergeSelectedItems";
			this.btnMergeSelectedItems.Size = new System.Drawing.Size(234, 35);
			this.btnMergeSelectedItems.TabIndex = 2;
			this.btnMergeSelectedItems.Text = "Merge Selected Items";
			this.btnMergeSelectedItems.UseVisualStyleBackColor = true;
			this.btnMergeSelectedItems.Click += new System.EventHandler(this.btnGetSelected_Click);
			// 
			// grboxBranchInfo
			// 
			this.grboxBranchInfo.Controls.Add(this.uxAllowMultiLevelMerge);
			this.grboxBranchInfo.Controls.Add(this.uxTargetBranch);
			this.grboxBranchInfo.Controls.Add(this.uxSourceBranch);
			this.grboxBranchInfo.Controls.Add(this.lblTargetbranch);
			this.grboxBranchInfo.Controls.Add(this.lblSource);
			this.grboxBranchInfo.Controls.Add(this.btnMergeSelectedItems);
			this.grboxBranchInfo.Controls.Add(this.btnGetMergeCandidates);
			this.grboxBranchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grboxBranchInfo.Location = new System.Drawing.Point(12, 27);
			this.grboxBranchInfo.Name = "grboxBranchInfo";
			this.grboxBranchInfo.Size = new System.Drawing.Size(331, 185);
			this.grboxBranchInfo.TabIndex = 3;
			this.grboxBranchInfo.TabStop = false;
			this.grboxBranchInfo.Text = "Branch Info";
			// 
			// uxAllowMultiLevelMerge
			// 
			this.uxAllowMultiLevelMerge.AutoSize = true;
			this.uxAllowMultiLevelMerge.Location = new System.Drawing.Point(104, 49);
			this.uxAllowMultiLevelMerge.Name = "uxAllowMultiLevelMerge";
			this.uxAllowMultiLevelMerge.Size = new System.Drawing.Size(134, 17);
			this.uxAllowMultiLevelMerge.TabIndex = 9;
			this.uxAllowMultiLevelMerge.Text = "Allow Multi-level Merge";
			this.uxAllowMultiLevelMerge.UseVisualStyleBackColor = true;
			this.uxAllowMultiLevelMerge.Visible = false;
			this.uxAllowMultiLevelMerge.CheckedChanged += new System.EventHandler(this.uxAllowMultiLevelMerge_CheckedChanged);
			// 
			// uxTargetBranch
			// 
			this.uxTargetBranch.DroppedDown = false;
			this.uxTargetBranch.Location = new System.Drawing.Point(104, 72);
			this.uxTargetBranch.Name = "uxTargetBranch";
			this.uxTargetBranch.PathSeparator = "/";
			this.uxTargetBranch.SelectedNode = null;
			this.uxTargetBranch.ShowPath = true;
			this.uxTargetBranch.Size = new System.Drawing.Size(218, 23);
			this.uxTargetBranch.TabIndex = 8;
			this.uxTargetBranch.SelectedNodeChanged += new System.EventHandler(this.uxTargetBranch_SelectedNodeChanged);
			// 
			// uxSourceBranch
			// 
			this.uxSourceBranch.DroppedDown = false;
			this.uxSourceBranch.Location = new System.Drawing.Point(104, 20);
			this.uxSourceBranch.Name = "uxSourceBranch";
			this.uxSourceBranch.PathSeparator = "/";
			this.uxSourceBranch.SelectedNode = null;
			this.uxSourceBranch.ShowPath = true;
			this.uxSourceBranch.Size = new System.Drawing.Size(218, 23);
			this.uxSourceBranch.TabIndex = 7;
			this.uxSourceBranch.SelectedNodeChanged += new System.EventHandler(this.uxSourceBranch_SelectedNodeChanged);
			// 
			// lblTargetbranch
			// 
			this.lblTargetbranch.AutoSize = true;
			this.lblTargetbranch.Location = new System.Drawing.Point(17, 77);
			this.lblTargetbranch.Name = "lblTargetbranch";
			this.lblTargetbranch.Size = new System.Drawing.Size(78, 13);
			this.lblTargetbranch.TabIndex = 5;
			this.lblTargetbranch.Text = "Target Branch:";
			// 
			// lblSource
			// 
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new System.Drawing.Point(17, 28);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(81, 13);
			this.lblSource.TabIndex = 3;
			this.lblSource.Text = "Source Branch:";
			// 
			// grboxChangeSetInfo
			// 
			this.grboxChangeSetInfo.Controls.Add(this.lblWorkitemDetails);
			this.grboxChangeSetInfo.Controls.Add(this.lblChangesetDetails);
			this.grboxChangeSetInfo.Controls.Add(this.txtWorkItemDetails);
			this.grboxChangeSetInfo.Controls.Add(this.txtChangesetDetails);
			this.grboxChangeSetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grboxChangeSetInfo.Location = new System.Drawing.Point(349, 27);
			this.grboxChangeSetInfo.Name = "grboxChangeSetInfo";
			this.grboxChangeSetInfo.Size = new System.Drawing.Size(470, 164);
			this.grboxChangeSetInfo.TabIndex = 4;
			this.grboxChangeSetInfo.TabStop = false;
			this.grboxChangeSetInfo.Text = "Changeset & Work Items Details";
			// 
			// lblWorkitemDetails
			// 
			this.lblWorkitemDetails.AutoSize = true;
			this.lblWorkitemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWorkitemDetails.Location = new System.Drawing.Point(309, 22);
			this.lblWorkitemDetails.Name = "lblWorkitemDetails";
			this.lblWorkitemDetails.Size = new System.Drawing.Size(91, 13);
			this.lblWorkitemDetails.TabIndex = 3;
			this.lblWorkitemDetails.Text = "Work Item Details";
			// 
			// lblChangesetDetails
			// 
			this.lblChangesetDetails.AutoSize = true;
			this.lblChangesetDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChangesetDetails.Location = new System.Drawing.Point(83, 22);
			this.lblChangesetDetails.Name = "lblChangesetDetails";
			this.lblChangesetDetails.Size = new System.Drawing.Size(93, 13);
			this.lblChangesetDetails.TabIndex = 2;
			this.lblChangesetDetails.Text = "Changeset Details";
			// 
			// txtWorkItemDetails
			// 
			this.txtWorkItemDetails.BackColor = System.Drawing.Color.White;
			this.txtWorkItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtWorkItemDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWorkItemDetails.Location = new System.Drawing.Point(244, 38);
			this.txtWorkItemDetails.Multiline = true;
			this.txtWorkItemDetails.Name = "txtWorkItemDetails";
			this.txtWorkItemDetails.ReadOnly = true;
			this.txtWorkItemDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtWorkItemDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtWorkItemDetails.Size = new System.Drawing.Size(220, 120);
			this.txtWorkItemDetails.TabIndex = 1;
			this.txtWorkItemDetails.WordWrap = false;
			// 
			// txtChangesetDetails
			// 
			this.txtChangesetDetails.BackColor = System.Drawing.Color.White;
			this.txtChangesetDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtChangesetDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.txtChangesetDetails.Location = new System.Drawing.Point(7, 38);
			this.txtChangesetDetails.Multiline = true;
			this.txtChangesetDetails.Name = "txtChangesetDetails";
			this.txtChangesetDetails.ReadOnly = true;
			this.txtChangesetDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtChangesetDetails.Size = new System.Drawing.Size(231, 120);
			this.txtChangesetDetails.TabIndex = 0;
			this.txtChangesetDetails.WordWrap = false;
			// 
			// tsmMenu
			// 
			this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmTools});
			this.tsmMenu.Location = new System.Drawing.Point(0, 0);
			this.tsmMenu.Name = "tsmMenu";
			this.tsmMenu.Size = new System.Drawing.Size(833, 24);
			this.tsmMenu.TabIndex = 5;
			this.tsmMenu.Text = "menuStrip1";
			// 
			// tsmFile
			// 
			this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnect,
            this.toolStripMenuItem2,
            this.tsmiGetMergeCandidates,
            this.tsmiMergeSelectedItems,
            this.toolStripMenuItem1,
            this.tsmiExit});
			this.tsmFile.Name = "tsmFile";
			this.tsmFile.Size = new System.Drawing.Size(37, 20);
			this.tsmFile.Text = "File";
			// 
			// tsmiConnect
			// 
			this.tsmiConnect.Name = "tsmiConnect";
			this.tsmiConnect.Size = new System.Drawing.Size(191, 22);
			this.tsmiConnect.Text = "Connect To Server";
			this.tsmiConnect.Click += new System.EventHandler(this.tsmiConnect_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
			// 
			// tsmiGetMergeCandidates
			// 
			this.tsmiGetMergeCandidates.Name = "tsmiGetMergeCandidates";
			this.tsmiGetMergeCandidates.Size = new System.Drawing.Size(191, 22);
			this.tsmiGetMergeCandidates.Text = "Get Merge Candidates";
			this.tsmiGetMergeCandidates.Click += new System.EventHandler(this.btnGetMergeCandidates_Click);
			// 
			// tsmiMergeSelectedItems
			// 
			this.tsmiMergeSelectedItems.Name = "tsmiMergeSelectedItems";
			this.tsmiMergeSelectedItems.Size = new System.Drawing.Size(191, 22);
			this.tsmiMergeSelectedItems.Text = "Merge Selected Items";
			this.tsmiMergeSelectedItems.Click += new System.EventHandler(this.btnGetSelected_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(191, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// tsmTools
			// 
			this.tsmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
			this.tsmTools.Name = "tsmTools";
			this.tsmTools.Size = new System.Drawing.Size(48, 20);
			this.tsmTools.Text = "Tools";
			// 
			// tsmiOptions
			// 
			this.tsmiOptions.Name = "tsmiOptions";
			this.tsmiOptions.Size = new System.Drawing.Size(116, 22);
			this.tsmiOptions.Text = "Options";
			this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMergeCandidates,
            this.tsslSelectedItems});
			this.statusStrip.Location = new System.Drawing.Point(0, 479);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(833, 24);
			this.statusStrip.TabIndex = 6;
			this.statusStrip.Text = "statusStrip";
			// 
			// tsslMergeCandidates
			// 
			this.tsslMergeCandidates.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsslMergeCandidates.Name = "tsslMergeCandidates";
			this.tsslMergeCandidates.Size = new System.Drawing.Size(119, 19);
			this.tsslMergeCandidates.Text = "Merge Candidates: 0";
			// 
			// tsslSelectedItems
			// 
			this.tsslSelectedItems.Name = "tsslSelectedItems";
			this.tsslSelectedItems.Size = new System.Drawing.Size(95, 19);
			this.tsslSelectedItems.Text = "Selected Items: 0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(353, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Merge Path:";
			// 
			// uxMergePath
			// 
			this.uxMergePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uxMergePath.Location = new System.Drawing.Point(415, 196);
			this.uxMergePath.Name = "uxMergePath";
			this.uxMergePath.ReadOnly = true;
			this.uxMergePath.Size = new System.Drawing.Size(404, 20);
			this.uxMergePath.TabIndex = 8;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 503);
			this.Controls.Add(this.uxMergePath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.grboxChangeSetInfo);
			this.Controls.Add(this.grboxBranchInfo);
			this.Controls.Add(this.grdMergeCandidates);
			this.Controls.Add(this.tsmMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.tsmMenu;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Merge Suite";
			((System.ComponentModel.ISupportInitialize)(this.grdMergeCandidates)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.changesetViewBindingSource)).EndInit();
			this.grboxBranchInfo.ResumeLayout(false);
			this.grboxBranchInfo.PerformLayout();
			this.grboxChangeSetInfo.ResumeLayout(false);
			this.grboxChangeSetInfo.PerformLayout();
			this.tsmMenu.ResumeLayout(false);
			this.tsmMenu.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMergeCandidates;
        private System.Windows.Forms.DataGridView grdMergeCandidates;
        private System.Windows.Forms.BindingSource changesetViewBindingSource;
        private System.Windows.Forms.Button btnMergeSelectedItems;
        private System.Windows.Forms.GroupBox grboxBranchInfo;
        private System.Windows.Forms.Label lblTargetbranch;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.GroupBox grboxChangeSetInfo;
        private System.Windows.Forms.Label lblWorkitemDetails;
        private System.Windows.Forms.Label lblChangesetDetails;
        private System.Windows.Forms.TextBox txtWorkItemDetails;
        private System.Windows.Forms.TextBox txtChangesetDetails;
        private System.Windows.Forms.MenuStrip tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetMergeCandidates;
        private System.Windows.Forms.ToolStripMenuItem tsmiMergeSelectedItems;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslMergeCandidates;
        private System.Windows.Forms.ToolStripStatusLabel tsslSelectedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn changesetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private ComboTreeBox uxTargetBranch;
        private ComboTreeBox uxSourceBranch;
        private System.Windows.Forms.CheckBox uxAllowMultiLevelMerge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxMergePath;
    }
}

