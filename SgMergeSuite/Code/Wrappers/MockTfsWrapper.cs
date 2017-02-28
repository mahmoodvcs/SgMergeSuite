using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.VersionControl.Client;
using SgMergeSuite.Code.ModelViews;

namespace SgMergeSuite.Code.Wrappers
{
	public class MockTfsWrapper : TfsWrapperBase
	{
		public override string ServerPath { get; protected set; }

		public override string WorkspaceName { get; protected set; }

		public override string WorkspaceOwner { get; protected set; }

		public override void CheckInPendingChangesets(string comment)
		{
		}

		public override void CheckInPendingChangesets(string comment, CheckinNote checkinNote, WorkItemCheckinInfo[] workItems, PolicyOverrideInfo policyOverrideInfo)
		{
		}

		public override ChangesetView GetChangesetDetail(int changesetId)
		{
			return new ModelViews.ChangesetView()
			{
				
			}
		}

		public override List<ChangesetView> GetMergeCandidates(string sourceBranch, string targetBranch, RecursionType recursionType = RecursionType.Full)
		{
			throw new NotImplementedException();
		}

		public override GetStatus MergeChangeset(string sourceBranch, string targetBranch, int changesetId)
		{
			throw new NotImplementedException();
		}

		public override int PendingChangesCount()
		{
			throw new NotImplementedException();
		}
	}
}
