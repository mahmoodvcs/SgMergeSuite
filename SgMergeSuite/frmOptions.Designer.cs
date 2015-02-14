namespace SgMergeSuite
{
    partial class frmOptions
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
            this.grboxApplicationOptions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTfsServerPath = new System.Windows.Forms.Label();
            this.lblWorkspaceName = new System.Windows.Forms.Label();
            this.lblWorkspaceOwner = new System.Windows.Forms.Label();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.txtWorkspaceName = new System.Windows.Forms.TextBox();
            this.txtWorkspaceOwner = new System.Windows.Forms.TextBox();
            this.grboxApplicationOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxApplicationOptions
            // 
            this.grboxApplicationOptions.Controls.Add(this.txtWorkspaceOwner);
            this.grboxApplicationOptions.Controls.Add(this.txtWorkspaceName);
            this.grboxApplicationOptions.Controls.Add(this.txtServerPath);
            this.grboxApplicationOptions.Controls.Add(this.lblWorkspaceOwner);
            this.grboxApplicationOptions.Controls.Add(this.lblWorkspaceName);
            this.grboxApplicationOptions.Controls.Add(this.lblTfsServerPath);
            this.grboxApplicationOptions.Location = new System.Drawing.Point(13, 12);
            this.grboxApplicationOptions.Name = "grboxApplicationOptions";
            this.grboxApplicationOptions.Size = new System.Drawing.Size(293, 142);
            this.grboxApplicationOptions.TabIndex = 0;
            this.grboxApplicationOptions.TabStop = false;
            this.grboxApplicationOptions.Text = "Application Options";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTfsServerPath
            // 
            this.lblTfsServerPath.AutoSize = true;
            this.lblTfsServerPath.Location = new System.Drawing.Point(49, 36);
            this.lblTfsServerPath.Name = "lblTfsServerPath";
            this.lblTfsServerPath.Size = new System.Drawing.Size(66, 13);
            this.lblTfsServerPath.TabIndex = 0;
            this.lblTfsServerPath.Text = "Server Path:";
            // 
            // lblWorkspaceName
            // 
            this.lblWorkspaceName.AutoSize = true;
            this.lblWorkspaceName.Location = new System.Drawing.Point(19, 61);
            this.lblWorkspaceName.Name = "lblWorkspaceName";
            this.lblWorkspaceName.Size = new System.Drawing.Size(96, 13);
            this.lblWorkspaceName.TabIndex = 1;
            this.lblWorkspaceName.Text = "Workspace Name:";
            // 
            // lblWorkspaceOwner
            // 
            this.lblWorkspaceOwner.AutoSize = true;
            this.lblWorkspaceOwner.Location = new System.Drawing.Point(16, 87);
            this.lblWorkspaceOwner.Name = "lblWorkspaceOwner";
            this.lblWorkspaceOwner.Size = new System.Drawing.Size(99, 13);
            this.lblWorkspaceOwner.TabIndex = 2;
            this.lblWorkspaceOwner.Text = "Workspace Owner:";
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(121, 33);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(166, 20);
            this.txtServerPath.TabIndex = 3;
            // 
            // txtWorkspaceName
            // 
            this.txtWorkspaceName.Location = new System.Drawing.Point(121, 58);
            this.txtWorkspaceName.Name = "txtWorkspaceName";
            this.txtWorkspaceName.Size = new System.Drawing.Size(166, 20);
            this.txtWorkspaceName.TabIndex = 4;
            // 
            // txtWorkspaceOwner
            // 
            this.txtWorkspaceOwner.Location = new System.Drawing.Point(121, 84);
            this.txtWorkspaceOwner.Name = "txtWorkspaceOwner";
            this.txtWorkspaceOwner.Size = new System.Drawing.Size(166, 20);
            this.txtWorkspaceOwner.TabIndex = 5;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 193);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grboxApplicationOptions);
            this.Name = "frmOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.grboxApplicationOptions.ResumeLayout(false);
            this.grboxApplicationOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxApplicationOptions;
        private System.Windows.Forms.TextBox txtWorkspaceOwner;
        private System.Windows.Forms.TextBox txtWorkspaceName;
        private System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.Label lblWorkspaceOwner;
        private System.Windows.Forms.Label lblWorkspaceName;
        private System.Windows.Forms.Label lblTfsServerPath;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}