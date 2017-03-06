using System.Collections.Generic;
using Microsoft.TeamFoundation.VersionControl.Client;
using SgMergeSuite.Code.ModelViews;

namespace SgMergeSuite.Code.Wrappers
{
	public interface ITfsWrapper
	{
		List<BranchInfo> Branches { get; set; }
		List<BranchInfo> BranchesLogicalHierarchy { get; set; }
		string ServerPath { get; }
		string WorkspaceName { get; }
		string WorkspaceOwner { get; }
		Workspace Workspace { get; }

		void CheckInPendingChangesets(string comment);
		void CheckInPendingChangesets(string comment, CheckinNote checkinNote, WorkItemCheckinInfo[] workItems, PolicyOverrideInfo policyOverrideInfo);
		BranchInfo FindBranch(string path);
		ChangesetView GetChangesetDetail(int changesetId);
		List<ChangesetView> GetMergeCandidates(string sourceBranch, string targetBranch, RecursionType recursionType = RecursionType.Full);
		List<BranchInfo> GetPath(string sourcePath, string targetPath);
		GetStatus MergeChangeset(string sourceBranch, string targetBranch, int changesetId);
		int PendingChangesCount();
	}
}