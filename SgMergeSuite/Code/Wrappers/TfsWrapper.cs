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
    public class TfsWrapper
    {
        public string ServerPath { get; private set; }
        public string WorkspaceName { get; private set; }
        public string WorkspaceOwner { get; private set; }
        protected VersionControlServer TfsVersionControlServer { get; set; }
        protected Workspace Workspace { get; set; }

        public TfsWrapper(string serverPath, string workspaceName, string workspaceOwner)
        {
            ServerPath = serverPath;
            var tpc = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(serverPath));
            TfsVersionControlServer = (VersionControlServer) tpc.GetService(typeof (VersionControlServer));
            Workspace = TfsVersionControlServer.GetWorkspace(workspaceName, workspaceOwner);
        }

        public List<ChangesetView> GetMergeCandidates(string sourceBranch, string targetBranch,
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

        public ChangesetView GetChangesetDetail(int changesetId)
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
                    Id=w.Id,
                    Obj = w
                }).ToList()
            };
            return result;
        }

        public GetStatus MergeChangeset( string sourceBranch, string targetBranch, int changesetId)
        {
            var changeSet = new ChangesetVersionSpec(changesetId);
            return Workspace.Merge(sourceBranch, targetBranch, changeSet, changeSet, LockLevel.None, RecursionType.Full, MergeOptionsEx.None);
        }


        public void CheckInPendingChangesets(string comment)
        {
            CheckInPendingChangesets(comment, null, new WorkItemCheckinInfo[] {}, new PolicyOverrideInfo(".", new PolicyFailure[] {}));
        }

        public void CheckInPendingChangesets(string comment, CheckinNote checkinNote, WorkItemCheckinInfo[] workItems, PolicyOverrideInfo policyOverrideInfo)
        {
            Workspace.CheckIn(Workspace.GetPendingChanges(), comment, checkinNote, workItems, policyOverrideInfo);
        }

        public int PendingChangesCount()
        {
            return Workspace.GetPendingChanges().Count();
        }
    }
}
