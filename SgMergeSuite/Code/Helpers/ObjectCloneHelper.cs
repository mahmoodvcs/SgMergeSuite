using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using SgMergeSuite.Code.Infrast;

namespace SgMergeSuite.Code.Helpers
{
    public static class ObjectCloneHelper
    {
        public static T DeepClone<T>(T obj) where T: ICloneable<T>
        {
            object objResult = null;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, obj);

                ms.Position = 0;
                objResult = bf.Deserialize(ms);
            }
            return (T)objResult;
        }

        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable<T>
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}
