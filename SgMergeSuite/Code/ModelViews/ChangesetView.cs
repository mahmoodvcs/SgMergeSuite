using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.VersionControl.Client;
using SgMergeSuite.Code.Helpers;
using SgMergeSuite.Code.Infrast;

namespace SgMergeSuite.Code.ModelViews
{
    [Serializable]
    public class ChangesetView : ICloneable<ChangesetView>
    {
        public ChangesetView()
        {
            Changes = new List<ChangeView>();
            WorkItems = new List<WorkItemView>();
        }
        public int ChangesetId { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public bool HasProcessed { get; set; }
        public PolicyOverrideInfo PolicyOverrideInfo { get; set; }
        public CheckinNote CheckinNote { get; set; }
        public List<ChangeView> Changes { get; set; }
        public List<WorkItemView> WorkItems { get; set; }

        public ChangesetView Clone()
        {
            return ObjectCloneHelper.DeepClone(this);
        }
    }
}
