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
			this.btnApply = new System.Windows.Forms.Button();
			this.txtRemoveStrings = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFindWhat = new System.Windows.Forms.TextBox();
			this.cbNOCIPosition = new System.Windows.Forms.ComboBox();
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtReplaceWith = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbNoCIState = new System.Windows.Forms.ComboBox();
			this.grdMergedItems = new System.Windows.Forms.DataGridView();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.prgProgressbar = new System.Windows.Forms.ProgressBar();
			this.statusImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.changesetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mergeItemViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.grboxMergeInfo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMergedItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mergeItemViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(9, 430);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(74, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// grboxMergeInfo
			// 
			this.grboxMergeInfo.Controls.Add(this.btnApply);
			this.grboxMergeInfo.Controls.Add(this.txtRemoveStrings);
			this.grboxMergeInfo.Controls.Add(this.label5);
			this.grboxMergeInfo.Controls.Add(this.txtFindWhat);
			this.grboxMergeInfo.Controls.Add(this.cbNOCIPosition);
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
			this.grboxMergeInfo.Controls.Add(this.groupBox1);
			this.grboxMergeInfo.Controls.Add(this.groupBox2);
			this.grboxMergeInfo.Location = new System.Drawing.Point(9, 12);
			this.grboxMergeInfo.Name = "grboxMergeInfo";
			this.grboxMergeInfo.Size = new System.Drawing.Size(815, 225);
			this.grboxMergeInfo.TabIndex = 2;
			this.grboxMergeInfo.TabStop = false;
			this.grboxMergeInfo.Text = "Merge Details";
			// 
			// btnApply
			// 
			this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnApply.ForeColor = System.Drawing.Color.ForestGreen;
			this.btnApply.Location = new System.Drawing.Point(580, 144);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(222, 31);
			this.btnApply.TabIndex = 16;
			this.btnApply.Text = "Preview Changes";
			this.btnApply.UseVisualStyleBackColor = false;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// txtRemoveStrings
			// 
			this.txtRemoveStrings.Location = new System.Drawing.Point(580, 32);
			this.txtRemoveStrings.Multiline = true;
			this.txtRemoveStrings.Name = "txtRemoveStrings";
			this.txtRemoveStrings.Size = new System.Drawing.Size(222, 106);
			this.txtRemoveStrings.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(577, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 22;
			this.label5.Text = "Remove Strings:";
			// 
			// txtFindWhat
			// 
			this.txtFindWhat.Location = new System.Drawing.Point(87, 183);
			this.txtFindWhat.Name = "txtFindWhat";
			this.txtFindWhat.Size = new System.Drawing.Size(172, 20);
			this.txtFindWhat.TabIndex = 16;
			// 
			// cbNOCIPosition
			// 
			this.cbNOCIPosition.Enabled = false;
			this.cbNOCIPosition.FormattingEnabled = true;
			this.cbNOCIPosition.Items.AddRange(new object[] {
            "After All Changesets",
            "Before All Changesets",
            "After All Changesets Expect The Last",
            "Before All Changesets Expect The Last"});
			this.cbNOCIPosition.Location = new System.Drawing.Point(346, 121);
			this.cbNOCIPosition.Name = "cbNOCIPosition";
			this.cbNOCIPosition.Size = new System.Drawing.Size(217, 21);
			this.cbNOCIPosition.TabIndex = 14;
			this.cbNOCIPosition.Text = "Before All Changesets Expect The Last";
			// 
			// txtCommentPrefix
			// 
			this.txtCommentPrefix.Location = new System.Drawing.Point(346, 70);
			this.txtCommentPrefix.Name = "txtCommentPrefix";
			this.txtCommentPrefix.Size = new System.Drawing.Size(217, 20);
			this.txtCommentPrefix.TabIndex = 12;
			// 
			// lblCommentPrefix
			// 
			this.lblCommentPrefix.AutoSize = true;
			this.lblCommentPrefix.Location = new System.Drawing.Point(263, 73);
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
			this.chkIncludeWorkItems.Location = new System.Drawing.Point(20, 70);
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
			this.lblMergedCount.Location = new System.Drawing.Point(470, 47);
			this.lblMergedCount.Name = "lblMergedCount";
			this.lblMergedCount.Size = new System.Drawing.Size(43, 13);
			this.lblMergedCount.TabIndex = 9;
			this.lblMergedCount.Text = "---------";
			// 
			// lblTotalChangesetCount
			// 
			this.lblTotalChangesetCount.AutoSize = true;
			this.lblTotalChangesetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalChangesetCount.Location = new System.Drawing.Point(514, 25);
			this.lblTotalChangesetCount.Name = "lblTotalChangesetCount";
			this.lblTotalChangesetCount.Size = new System.Drawing.Size(43, 13);
			this.lblTotalChangesetCount.TabIndex = 8;
			this.lblTotalChangesetCount.Text = "---------";
			// 
			// lblTargetBranch
			// 
			this.lblTargetBranch.AutoSize = true;
			this.lblTargetBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTargetBranch.Location = new System.Drawing.Point(102, 47);
			this.lblTargetBranch.Name = "lblTargetBranch";
			this.lblTargetBranch.Size = new System.Drawing.Size(43, 13);
			this.lblTargetBranch.TabIndex = 7;
			this.lblTargetBranch.Text = "---------";
			// 
			// lblSourceBranch
			// 
			this.lblSourceBranch.AutoSize = true;
			this.lblSourceBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSourceBranch.Location = new System.Drawing.Point(104, 25);
			this.lblSourceBranch.Name = "lblSourceBranch";
			this.lblSourceBranch.Size = new System.Drawing.Size(43, 13);
			this.lblSourceBranch.TabIndex = 6;
			this.lblSourceBranch.Text = "---------";
			// 
			// lblMergedCountLabel
			// 
			this.lblMergedCountLabel.AutoSize = true;
			this.lblMergedCountLabel.Location = new System.Drawing.Point(389, 47);
			this.lblMergedCountLabel.Name = "lblMergedCountLabel";
			this.lblMergedCountLabel.Size = new System.Drawing.Size(77, 13);
			this.lblMergedCountLabel.TabIndex = 5;
			this.lblMergedCountLabel.Text = "Merged Count:";
			// 
			// lblTotalBranchLabel
			// 
			this.lblTotalBranchLabel.AutoSize = true;
			this.lblTotalBranchLabel.Location = new System.Drawing.Point(20, 47);
			this.lblTotalBranchLabel.Name = "lblTotalBranchLabel";
			this.lblTotalBranchLabel.Size = new System.Drawing.Size(78, 13);
			this.lblTotalBranchLabel.TabIndex = 4;
			this.lblTotalBranchLabel.Text = "Target Branch:";
			// 
			// lblTotalChangesetCountLabel
			// 
			this.lblTotalChangesetCountLabel.AutoSize = true;
			this.lblTotalChangesetCountLabel.Location = new System.Drawing.Point(389, 25);
			this.lblTotalChangesetCountLabel.Name = "lblTotalChangesetCountLabel";
			this.lblTotalChangesetCountLabel.Size = new System.Drawing.Size(119, 13);
			this.lblTotalChangesetCountLabel.TabIndex = 3;
			this.lblTotalChangesetCountLabel.Text = "Total Changeset Count:";
			// 
			// lblSourceBranchLabel
			// 
			this.lblSourceBranchLabel.AutoSize = true;
			this.lblSourceBranchLabel.Location = new System.Drawing.Point(17, 25);
			this.lblSourceBranchLabel.Name = "lblSourceBranchLabel";
			this.lblSourceBranchLabel.Size = new System.Drawing.Size(81, 13);
			this.lblSourceBranchLabel.TabIndex = 2;
			this.lblSourceBranchLabel.Text = "Source Branch:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtReplaceWith);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(9, 160);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(565, 53);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Replace";
			// 
			// txtReplaceWith
			// 
			this.txtReplaceWith.Location = new System.Drawing.Point(337, 23);
			this.txtReplaceWith.Name = "txtReplaceWith";
			this.txtReplaceWith.Size = new System.Drawing.Size(217, 20);
			this.txtReplaceWith.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(259, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Replace With:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Find What:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.cbNoCIState);
			this.groupBox2.Location = new System.Drawing.Point(9, 101);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(565, 53);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "***NO_CI***";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "NO_CI State:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(253, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "NO_CI Position:";
			// 
			// cbNoCIState
			// 
			this.cbNoCIState.FormattingEnabled = true;
			this.cbNoCIState.Items.AddRange(new object[] {
            "No Change",
            "Add NO_CI If Not Exist",
            "Remove NO_CI"});
			this.cbNoCIState.Location = new System.Drawing.Point(75, 19);
			this.cbNoCIState.Name = "cbNoCIState";
			this.cbNoCIState.Size = new System.Drawing.Size(172, 21);
			this.cbNoCIState.TabIndex = 23;
			this.cbNoCIState.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
			this.grdMergedItems.Location = new System.Drawing.Point(9, 243);
			this.grdMergedItems.Name = "grdMergedItems";
			this.grdMergedItems.ReadOnly = true;
			this.grdMergedItems.Size = new System.Drawing.Size(815, 181);
			this.grdMergedItems.TabIndex = 3;
			this.grdMergedItems.Click += new System.EventHandler(this.grdMergedItems_Click);
			this.grdMergedItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMergedItems_KeyDown);
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.ForeColor = System.Drawing.Color.DarkRed;
			this.btnStop.Location = new System.Drawing.Point(704, 193);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(108, 31);
			this.btnStop.TabIndex = 15;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Enabled = false;
			this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnStart.Location = new System.Drawing.Point(590, 193);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(108, 31);
			this.btnStart.TabIndex = 14;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// prgProgressbar
			// 
			this.prgProgressbar.Location = new System.Drawing.Point(644, 431);
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
			this.commentDataGridViewTextBoxColumn.Width = 600;
			// 
			// mergeItemViewBindingSource
			// 
			this.mergeItemViewBindingSource.DataSource = typeof(SgMergeSuite.Code.ModelViews.MergeItemView);
			// 
			// frmMerge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 461);
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
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMergedItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mergeItemViewBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grboxMergeInfo;
        private System.Windows.Forms.DataGridView grdMergedItems;
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
        private System.Windows.Forms.ComboBox cbNOCIPosition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFindWhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNoCIState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemoveStrings;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DataGridViewImageColumn statusImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changesetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}