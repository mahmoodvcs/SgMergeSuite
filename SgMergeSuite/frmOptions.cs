using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SgMergeSuite.Code.Helpers;
using SgMergeSuite.Properties;
using SgMergeSuite.Code.Wrappers;

namespace SgMergeSuite
{
    public partial class frmOptions : Form
    {
        public frmOptions(bool showBtnConnect = false)
        {
            InitializeComponent();
            txtServerPath.Text = ConfigHelper.VertionControlServerPath;
            txtWorkspaceName.Text = string.IsNullOrEmpty(ConfigHelper.WorkspaceName) || showBtnConnect ?
                Environment.MachineName :
                ConfigHelper.WorkspaceName;
            txtWorkspaceOwner.Text = string.IsNullOrEmpty(ConfigHelper.WorkspaceOwner) || showBtnConnect ?
                Environment.UserName :
                ConfigHelper.WorkspaceOwner;
            btnSave.Text = showBtnConnect ? "Connect" : "Save";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigHelper.VertionControlServerPath = txtServerPath.Text;
            ConfigHelper.WorkspaceName = txtWorkspaceName.Text;
            ConfigHelper.WorkspaceOwner = txtWorkspaceOwner.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
