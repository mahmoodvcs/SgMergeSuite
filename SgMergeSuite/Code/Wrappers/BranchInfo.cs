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
                var b = new Wrappers.BranchInfo(child, vcs);
                b.Parent = this;
                ChildBranches.Add(b);
            }

        }

        public BranchInfo GetRoot()
        {
            if (Parent == null)
                return this;
            return Parent.GetRoot();
        }

        public BranchInfo FindBranch(string path)
        {
            if (Name == path)
                return this;
            foreach (var ch in ChildBranches)
            {
                var br = ch.FindBranch(path);
                if (br != null)
                    return br;
            }
            return null;
        }
        public string Name { get; set; }
        public List<BranchInfo> ChildBranches { get; set; }
        public BranchObject BranchObject { get; set; }
        public BranchInfo Parent { get; set; }
    }
}
