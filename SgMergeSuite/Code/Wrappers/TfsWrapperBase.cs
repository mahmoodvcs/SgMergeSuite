using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.VersionControl.Client;
using SgMergeSuite.Code.ModelViews;

namespace SgMergeSuite.Code.Wrappers
{
	public abstract class TfsWrapperBase : ITfsWrapper
	{
		public List<BranchInfo> Branches { get; set; }
		public List<BranchInfo> BranchesLogicalHierarchy { get; set; }
		public abstract string ServerPath { get; protected set; }
		public abstract string WorkspaceName { get; protected set; }
		public abstract string WorkspaceOwner { get; protected set; }
		public abstract Workspace Workspace { get; protected set; }

		public abstract void CheckInPendingChangesets(string comment);
		public abstract void CheckInPendingChangesets(string comment, CheckinNote checkinNote, WorkItemCheckinInfo[] workItems, PolicyOverrideInfo policyOverrideInfo);
		public abstract ChangesetView GetChangesetDetail(int changesetId);
		public abstract List<ChangesetView> GetMergeCandidates(string sourceBranch, string targetBranch, RecursionType recursionType = RecursionType.Full);
		public abstract GetStatus MergeChangeset(string sourceBranch, string targetBranch, int changesetId);
		public abstract int PendingChangesCount();

		public virtual BranchInfo FindBranch(string path)
		{
			path = NormalizePath(path);
			foreach (var br in BranchesLogicalHierarchy)
			{
				var thebr = br.FindBranch(path);
				if (thebr != null)
					return thebr;
			}
			return null;
		}

		private static string NormalizePath(string path)
		{
			if (!path.StartsWith("$/"))
				path = "$/" + path;
			return path;
		}

		public virtual List<BranchInfo> GetPath(string sourcePath, string targetPath)
		{
			var sourceBranch = FindBranch(sourcePath);
			var targetBranch = FindBranch(targetPath);
			if (sourceBranch == null || targetBranch == null)
				return null;
			if (sourceBranch.GetRoot() != targetBranch.GetRoot())
				return null;
			List<BranchInfo> path = new List<Wrappers.BranchInfo>();

			var sourceToRoot = GetPathToRoot(sourceBranch);
			var targetToRoot = GetPathToRoot(targetBranch);

			int sourceIndex = -1, i;
			do
			{
				sourceIndex++;
				path.Add(sourceToRoot[sourceIndex]);
				i = targetToRoot.IndexOf(sourceToRoot[sourceIndex]);
			} while (i == -1);
			path.AddRange(targetToRoot.Take(i).Reverse());

			return path;
		}
		List<BranchInfo> GetPathToRoot(BranchInfo branch, List<BranchInfo> path = null)
		{
			if (path == null)
				path = new List<Wrappers.BranchInfo>();
			path.Add(branch);
			if (branch.Parent != null)
				path = GetPathToRoot(branch.Parent, path);
			return path;
		}

	}
}
