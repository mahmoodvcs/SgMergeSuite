using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace SgMergeSuite.Code.ModelViews
{
    public class MergeItemView
    {
        public int ChangesetId { get; set; }
        public string Comment { get; set; }
        public bool IsSuccessfull
        {
            get
            {
                return NumConflicts == 0 && NumFailures == 0;
            }
        }
        public int NumFailures { get; set; }
        public int NumConflicts { get; set; }
        public Image StatusImage
        {
            get
            {
                if (IsSuccessfull == true)
                {
                    return Properties.Resources.tick;
                }

                return Properties.Resources.fail;
            }


        }
    }
}
