using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SgMergeSuite.Code.Infrast
{
    public interface ICloneable<T>
    {
        T Clone();
    }
}
