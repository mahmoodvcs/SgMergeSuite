using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.VersionControl.Client;
using SgMergeSuite.Code.Helpers;
using SgMergeSuite.Code.Infrast;

namespace SgMergeSuite.Code.ModelViews
{
    [Serializable]
    public class ChangesetView : ICloneable<ChangesetView>, ISerializable
    {
        public ChangesetView()
        {
            Changes = new List<ChangeView>();
            WorkItems = new List<WorkItemView>();
        }
        protected ChangesetView(SerializationInfo info, StreamingContext context)
        {

            ChangesetId = (int)info.GetValue("ChangesetId", typeof(int));
            User = (string)info.GetValue("User", typeof(string));
            Date = (DateTime)info.GetValue("Date", typeof(DateTime));
            Comment = (string)info.GetValue("Comment", typeof(string));
            HasProcessed = (bool)info.GetValue("HasProcessed", typeof(bool));
            PolicyOverrideInfo = (PolicyOverrideInfo)info.GetValue("PolicyOverrideInfo", typeof(PolicyOverrideInfo));
            CheckinNote = (CheckinNote)info.GetValue("CheckinNote", typeof(CheckinNote));
            Changes = (List<ChangeView>)info.GetValue("Changes", typeof(List<ChangeView>));
            WorkItems = (List<WorkItemView>)info.GetValue("WorkItems", typeof(List<WorkItemView>));
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ChangesetId", ChangesetId);
            info.AddValue("User", User);
            info.AddValue("Date", Date);
            info.AddValue("Comment", Comment);
            info.AddValue("HasProcessed", HasProcessed);
            info.AddValue("PolicyOverrideInfo", PolicyOverrideInfo);
            info.AddValue("CheckinNote", CheckinNote);
            info.AddValue("Changes", Changes);
            info.AddValue("WorkItems", WorkItems);
        }
    }
}
