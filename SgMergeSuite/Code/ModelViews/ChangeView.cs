using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace SgMergeSuite.Code.ModelViews
{
    [Serializable]
    public class ChangeView
    {
        public string Path { get; set; }
        public ChangeType Type { get; set; }

        public override string ToString()
        {
            return string.Format("({0}) {1}", Type, Path);
        }
    }
}
