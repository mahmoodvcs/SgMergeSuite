using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using SgMergeSuite.Code.ModelViews;
using Microsoft.TeamFoundation.VersionControl.Common;

namespace SgMergeSuite.Code.Wrappers
{
    public class TfsWrapper : TfsWrapperBase
	{
        public override string ServerPath { get; protected set; }
        public override string WorkspaceName { get; protected set; }
        public override string WorkspaceOwner { get; protected set; }
        protected VersionControlServer TfsVersionControlServer { get; set; }
        protected Workspace Workspace { get; set; }

        public TfsWrapper(string serverPath, string workspaceName, string workspaceOwner)
        {
            ServerPath = serverPath;
            var tpc = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(serverPath));
            TfsVersionControlServer = (VersionControlServer)tpc.GetService(typeof(VersionControlServer));
            Workspace = TfsVersionControlServer.GetWorkspace(workspaceName, workspaceOwner);
            CreateBranchHierarchy();
        }

        private void CreateBranchHierarchy()
        {
            BranchObject[] bos = TfsVersionControlServer.QueryRootBranchObjects(RecursionType.OneLevel);
            BranchesLogicalHierarchy = new List<Wrappers.BranchInfo>();
            foreach (var o in bos)
            {
                BranchesLogicalHierarchy.Add(new Wrappers.BranchInfo(o, TfsVersionControlServer));
            }

            Func<BranchInfo, List<BranchObject>> getChilds = null;
            getChilds = (BranchInfo b) =>
            {
                List<BranchObject> l = b.ChildBranches.SelectMany(x => getChilds(x)).ToList();
                l.Add(b.BranchObject);
                return l;
            };
            var all = BranchesLogicalHierarchy.SelectMany(b => getChilds(b)).OrderBy(b => b.Properties.RootItem.Item);

            var rootItem = new BranchInfo();
            foreach (var br in all)
            {
                AddNode(br, rootItem);
            }
            Branches = rootItem.ChildBranches;
        }

        private void AddNode(BranchObject br, BranchInfo rootItem)
        {
            var nameParts = br.Properties.RootItem.Item.Split('/').ToList();
            nameParts.RemoveAt(0);
            AddNode(nameParts, 0, rootItem);
        }

        private void AddNode(List<string> nameParts, int index, BranchInfo rootItem)
        {
            var name = nameParts[index];
            var node = rootItem.ChildBranches.FirstOrDefault(n => n.Name == name);
            if (node == null)
            {
                node = new BranchInfo()
                {
                    Name = name,
                };
                rootItem.ChildBranches.Add(node);
            }
            index++;
            if (index < nameParts.Count)
                AddNode(nameParts, index, node);
        }

        public override List<ChangesetView> GetMergeCandidates(string sourceBranch, string targetBranch,
            RecursionType recursionType = RecursionType.Full)
        {
            var mergeCandidates = TfsVersionControlServer.GetMergeCandidates(sourceBranch, targetBranch, recursionType);
            return mergeCandidates.Select(m => new ChangesetView
            {
                ChangesetId = m.Changeset.ChangesetId,
                Date = m.Changeset.CreationDate,
                User = m.Changeset.OwnerDisplayName,
                Comment = m.Changeset.Comment
            }).ToList();
        }

        public override ChangesetView GetChangesetDetail(int changesetId)
        {
            var changeset = TfsVersionControlServer.GetChangeset(changesetId);
            if (changeset == null)
                return null;

            var result = new ChangesetView()
            {
                ChangesetId = changeset.ChangesetId,
                Comment = changeset.Comment,
                User = changeset.OwnerDisplayName,
                Date = changeset.CreationDate,
                CheckinNote = changeset.CheckinNote,
                PolicyOverrideInfo = changeset.PolicyOverride,
                Changes = changeset.Changes.Select(c => new ChangeView()
                {
                    Path = c.Item.ServerItem,
                    Type = c.ChangeType
                }).ToList(),
                WorkItems = changeset.WorkItems.Select(w => new WorkItemView()
                {
                    Title = w.Title,
                    Type = w.Type,
                    Id = w.Id,
                    Obj = w
                }).ToList()
            };
            return result;
        }

        public override GetStatus MergeChangeset(string sourceBranch, string targetBranch, int changesetId)
        {
            var changeSet = new ChangesetVersionSpec(changesetId);
            return Workspace.Merge(sourceBranch, targetBranch, changeSet, changeSet, LockLevel.None, RecursionType.Full, MergeOptionsEx.None);
        }


        public override void CheckInPendingChangesets(string comment)
        {
            CheckInPendingChangesets(comment, null, new WorkItemCheckinInfo[] { }, new PolicyOverrideInfo(".", new PolicyFailure[] { }));
        }

        public override void CheckInPendingChangesets(string comment, CheckinNote checkinNote, WorkItemCheckinInfo[] workItems, PolicyOverrideInfo policyOverrideInfo)
        {
            Workspace.CheckIn(Workspace.GetPendingChanges(), comment, checkinNote, workItems, policyOverrideInfo);
        }

        public override int PendingChangesCount()
        {
            return Workspace.GetPendingChanges().Count();
        }

    }
}
