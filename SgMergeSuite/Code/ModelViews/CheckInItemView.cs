using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SgMergeSuite.Code.ModelViews
{
    public class CheckInItemView
    {
        public int ChenagesetId { get; set; }
        public MergeItemView MergeItem { get; set; }
        public bool IsSuccessfull { get; set; }
    }
}
