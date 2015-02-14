namespace SgMergeSuite
{
    partial class frmMerge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMerge));
            this.btnClose = new System.Windows.Forms.Button();
            this.grboxMergeInfo = new System.Windows.Forms.GroupBox();
            this.txtCommentPrefix = new System.Windows.Forms.TextBox();
            this.lblCommentPrefix = new System.Windows.Forms.Label();
            this.chkIncludeWorkItems = new System.Windows.Forms.CheckBox();
            this.lblMergedCount = new System.Windows.Forms.Label();
            this.lblTotalChangesetCount = new System.Windows.Forms.Label();
            this.lblTargetBranch = new System.Windows.Forms.Label();
            this.lblSourceBranch = new System.Windows.Forms.Label();
            this.lblMergedCountLabel = new System.Windows.Forms.Label();
            this.lblTotalBranchLabel = new System.Windows.Forms.Label();
            this.lblTotalChangesetCountLabel = new System.Windows.Forms.Label();
            this.lblSourceBranchLabel = new System.Windows.Forms.Label();
            this.grdMergedItems = new System.Windows.Forms.DataGridView();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.prgProgressbar = new System.Windows.Forms.ProgressBar();
            this.statusImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.changesetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mergeItemViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grboxMergeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMergedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mergeItemViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grboxMergeInfo
            // 
            this.grboxMergeInfo.Controls.Add(this.txtCommentPrefix);
            this.grboxMergeInfo.Controls.Add(this.lblCommentPrefix);
            this.grboxMergeInfo.Controls.Add(this.chkIncludeWorkItems);
            this.grboxMergeInfo.Controls.Add(this.lblMergedCount);
            this.grboxMergeInfo.Controls.Add(this.lblTotalChangesetCount);
            this.grboxMergeInfo.Controls.Add(this.lblTargetBranch);
            this.grboxMergeInfo.Controls.Add(this.lblSourceBranch);
            this.grboxMergeInfo.Controls.Add(this.lblMergedCountLabel);
            this.grboxMergeInfo.Controls.Add(this.lblTotalBranchLabel);
            this.grboxMergeInfo.Controls.Add(this.lblTotalChangesetCountLabel);
            this.grboxMergeInfo.Controls.Add(this.lblSourceBranchLabel);
            this.grboxMergeInfo.Location = new System.Drawing.Point(12, 12);
            this.grboxMergeInfo.Name = "grboxMergeInfo";
            this.grboxMergeInfo.Size = new System.Drawing.Size(568, 123);
            this.grboxMergeInfo.TabIndex = 2;
            this.grboxMergeInfo.TabStop = false;
            this.grboxMergeInfo.Text = "Merge Details";
            // 
            // txtCommentPrefix
            // 
            this.txtCommentPrefix.Location = new System.Drawing.Point(397, 68);
            this.txtCommentPrefix.Name = "txtCommentPrefix";
            this.txtCommentPrefix.Size = new System.Drawing.Size(158, 20);
            this.txtCommentPrefix.TabIndex = 12;
            // 
            // lblCommentPrefix
            // 
            this.lblCommentPrefix.AutoSize = true;
            this.lblCommentPrefix.Location = new System.Drawing.Point(308, 70);
            this.lblCommentPrefix.Name = "lblCommentPrefix";
            this.lblCommentPrefix.Size = new System.Drawing.Size(83, 13);
            this.lblCommentPrefix.TabIndex = 11;
            this.lblCommentPrefix.Text = "Comment Prefix:";
            // 
            // chkIncludeWorkItems
            // 
            this.chkIncludeWorkItems.AutoSize = true;
            this.chkIncludeWorkItems.Checked = true;
            this.chkIncludeWorkItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeWorkItems.Location = new System.Drawing.Point(46, 70);
            this.chkIncludeWorkItems.Name = "chkIncludeWorkItems";
            this.chkIncludeWorkItems.Size = new System.Drawing.Size(118, 17);
            this.chkIncludeWorkItems.TabIndex = 10;
            this.chkIncludeWorkItems.Text = "Include Work Items";
            this.chkIncludeWorkItems.UseVisualStyleBackColor = true;
            // 
            // lblMergedCount
            // 
            this.lblMergedCount.AutoSize = true;
            this.lblMergedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMergedCount.Location = new System.Drawing.Point(397, 47);
            this.lblMergedCount.Name = "lblMergedCount";
            this.lblMergedCount.Size = new System.Drawing.Size(43, 13);
            this.lblMergedCount.TabIndex = 9;
            this.lblMergedCount.Text = "---------";
            // 
            // lblTotalChangesetCount
            // 
            this.lblTotalChangesetCount.AutoSize = true;
            this.lblTotalChangesetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChangesetCount.Location = new System.Drawing.Point(168, 47);
            this.lblTotalChangesetCount.Name = "lblTotalChangesetCount";
            this.lblTotalChangesetCount.Size = new System.Drawing.Size(43, 13);
            this.lblTotalChangesetCount.TabIndex = 8;
            this.lblTotalChangesetCount.Text = "---------";
            // 
            // lblTargetBranch
            // 
            this.lblTargetBranch.AutoSize = true;
            this.lblTargetBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetBranch.Location = new System.Drawing.Point(398, 25);
            this.lblTargetBranch.Name = "lblTargetBranch";
            this.lblTargetBranch.Size = new System.Drawing.Size(43, 13);
            this.lblTargetBranch.TabIndex = 7;
            this.lblTargetBranch.Text = "---------";
            // 
            // lblSourceBranch
            // 
            this.lblSourceBranch.AutoSize = true;
            this.lblSourceBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceBranch.Location = new System.Drawing.Point(168, 25);
            this.lblSourceBranch.Name = "lblSourceBranch";
            this.lblSourceBranch.Size = new System.Drawing.Size(43, 13);
            this.lblSourceBranch.TabIndex = 6;
            this.lblSourceBranch.Text = "---------";
            // 
            // lblMergedCountLabel
            // 
            this.lblMergedCountLabel.AutoSize = true;
            this.lblMergedCountLabel.Location = new System.Drawing.Point(314, 47);
            this.lblMergedCountLabel.Name = "lblMergedCountLabel";
            this.lblMergedCountLabel.Size = new System.Drawing.Size(77, 13);
            this.lblMergedCountLabel.TabIndex = 5;
            this.lblMergedCountLabel.Text = "Merged Count:";
            // 
            // lblTotalBranchLabel
            // 
            this.lblTotalBranchLabel.AutoSize = true;
            this.lblTotalBranchLabel.Location = new System.Drawing.Point(314, 25);
            this.lblTotalBranchLabel.Name = "lblTotalBranchLabel";
            this.lblTotalBranchLabel.Size = new System.Drawing.Size(78, 13);
            this.lblTotalBranchLabel.TabIndex = 4;
            this.lblTotalBranchLabel.Text = "Target Branch:";
            // 
            // lblTotalChangesetCountLabel
            // 
            this.lblTotalChangesetCountLabel.AutoSize = true;
            this.lblTotalChangesetCountLabel.Location = new System.Drawing.Point(43, 47);
            this.lblTotalChangesetCountLabel.Name = "lblTotalChangesetCountLabel";
            this.lblTotalChangesetCountLabel.Size = new System.Drawing.Size(119, 13);
            this.lblTotalChangesetCountLabel.TabIndex = 3;
            this.lblTotalChangesetCountLabel.Text = "Total Changeset Count:";
            // 
            // lblSourceBranchLabel
            // 
            this.lblSourceBranchLabel.AutoSize = true;
            this.lblSourceBranchLabel.Location = new System.Drawing.Point(81, 25);
            this.lblSourceBranchLabel.Name = "lblSourceBranchLabel";
            this.lblSourceBranchLabel.Size = new System.Drawing.Size(81, 13);
            this.lblSourceBranchLabel.TabIndex = 2;
            this.lblSourceBranchLabel.Text = "Source Branch:";
            // 
            // grdMergedItems
            // 
            this.grdMergedItems.AllowUserToAddRows = false;
            this.grdMergedItems.AllowUserToDeleteRows = false;
            this.grdMergedItems.AutoGenerateColumns = false;
            this.grdMergedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMergedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusImageDataGridViewImageColumn,
            this.changesetIdDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.grdMergedItems.DataSource = this.mergeItemViewBindingSource;
            this.grdMergedItems.Location = new System.Drawing.Point(12, 141);
            this.grdMergedItems.Name = "grdMergedItems";
            this.grdMergedItems.ReadOnly = true;
            this.grdMergedItems.Size = new System.Drawing.Size(671, 181);
            this.grdMergedItems.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(598, 78);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 49);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(598, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 49);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // prgProgressbar
            // 
            this.prgProgressbar.Location = new System.Drawing.Point(522, 333);
            this.prgProgressbar.Name = "prgProgressbar";
            this.prgProgressbar.Size = new System.Drawing.Size(161, 18);
            this.prgProgressbar.Step = 5;
            this.prgProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgProgressbar.TabIndex = 13;
            // 
            // statusImageDataGridViewImageColumn
            // 
            this.statusImageDataGridViewImageColumn.DataPropertyName = "StatusImage";
            this.statusImageDataGridViewImageColumn.HeaderText = "Status";
            this.statusImageDataGridViewImageColumn.Name = "statusImageDataGridViewImageColumn";
            this.statusImageDataGridViewImageColumn.ReadOnly = true;
            this.statusImageDataGridViewImageColumn.Width = 50;
            // 
            // changesetIdDataGridViewTextBoxColumn
            // 
            this.changesetIdDataGridViewTextBoxColumn.DataPropertyName = "ChangesetId";
            this.changesetIdDataGridViewTextBoxColumn.HeaderText = "Changeset";
            this.changesetIdDataGridViewTextBoxColumn.Name = "changesetIdDataGridViewTextBoxColumn";
            this.changesetIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 400;
            // 
            // mergeItemViewBindingSource
            // 
            this.mergeItemViewBindingSource.DataSource = typeof(SgMergeSuite.Code.ModelViews.MergeItemView);
            // 
            // frmMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 363);
            this.Controls.Add(this.prgProgressbar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grdMergedItems);
            this.Controls.Add(this.grboxMergeInfo);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMerge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Selected Items";
            this.grboxMergeInfo.ResumeLayout(false);
            this.grboxMergeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMergedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mergeItemViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grboxMergeInfo;
        private System.Windows.Forms.DataGridView grdMergedItems;
        private System.Windows.Forms.DataGridViewImageColumn statusImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changesetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mergeItemViewBindingSource;
        private System.Windows.Forms.Label lblMergedCountLabel;
        private System.Windows.Forms.Label lblTotalBranchLabel;
        private System.Windows.Forms.Label lblTotalChangesetCountLabel;
        private System.Windows.Forms.Label lblSourceBranchLabel;
        private System.Windows.Forms.Label lblMergedCount;
        private System.Windows.Forms.Label lblTotalChangesetCount;
        private System.Windows.Forms.Label lblTargetBranch;
        private System.Windows.Forms.Label lblSourceBranch;
        private System.Windows.Forms.TextBox txtCommentPrefix;
        private System.Windows.Forms.Label lblCommentPrefix;
        private System.Windows.Forms.CheckBox chkIncludeWorkItems;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar prgProgressbar;
    }
}