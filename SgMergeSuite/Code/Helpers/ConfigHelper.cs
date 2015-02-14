using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SgMergeSuite.Properties;

namespace SgMergeSuite.Code.Helpers
{
    public static class ConfigHelper
    {
        public static string VertionControlServerPath
        {
            get
            {
                return Settings.Default.VersionControlServerPath;
            }
            set
            {
                Settings.Default.VersionControlServerPath = value;
                Settings.Default.Save();
            }
        }

        public static string WorkspaceName
        {
            get
            {
                return Settings.Default.WorkspaceName;
            }
            set
            {
                Settings.Default.WorkspaceName = value;
                Settings.Default.Save();
            }
        }

        public static string WorkspaceOwner
        {
            get
            {
                return Settings.Default.WorkspaceOwner;
            }
            set
            {
                Settings.Default.WorkspaceOwner = value;
                Settings.Default.Save();
            }
        }

        public static string SourceBranch
        {
            get
            {
                return Settings.Default.SourceBranch;
            }
            set
            {
                Settings.Default.SourceBranch = value;
                Settings.Default.Save();
            }
        }

        public static string TargetBranch
        {
            get
            {
                return Settings.Default.TargetBranch;
            }
            set
            {
                Settings.Default.TargetBranch = value;
                Settings.Default.Save();
            }
        }
    }
}
