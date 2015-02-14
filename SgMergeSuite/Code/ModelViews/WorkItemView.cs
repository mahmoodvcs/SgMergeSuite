using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace SgMergeSuite.Code.ModelViews
{
    [Serializable]
    public class WorkItemView
    {
        public int Id { get; set; }
        public WorkItemType Type { get; set; }
        public string Title { get; set; }
        public WorkItem Obj { get; set; }
        public override string ToString()
        {
            return string.Format("({0}) {1}", Id, Title);
        }
    }
}
