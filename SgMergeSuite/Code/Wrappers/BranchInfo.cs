using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SgMergeSuite.Code.Wrappers
{
    public class BranchInfo
    {
        public BranchInfo()
        {
            ChildBranches = new List<Wrappers.BranchInfo>();
        }
        public BranchInfo(BranchObject o)
            :this()
        {
            Name = o.Properties.RootItem.Item;
            BranchObject = o;
        }
        public BranchInfo(BranchObject o, VersionControlServer vcs)
            :this(o)
        {
            BranchObject[] childBos = vcs.QueryBranchObjects(o.Properties.RootItem, RecursionType.OneLevel);
            foreach (BranchObject child in childBos)
            {
                if (child.Properties.RootItem.Item == o.Properties.RootItem.Item)
                    continue;
                ChildBranches.Add(new Wrappers.BranchInfo(child, vcs));
            }

        }
        public string Name { get; set; }
        public List<BranchInfo> ChildBranches { get; set; }
        public BranchObject BranchObject { get; set; }
    }
}
