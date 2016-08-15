using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SgMergeSuite.Code.Infrast;

namespace SgMergeSuite.Code.Helpers
{
    public static class ObjectCloneHelper
    {
        public static T DeepClone<T>(T source) where T : ISerializable
        {
            //if (!typeof(T).IsSerializable)
            //{
            //    throw new ArgumentException("The type must be serializable.", "source");
            //}

            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
        public static T CloneDeep<T>(T obj)
        {
            object objResult = null;

            //using (var ms = new MemoryStream())
            //{
            //    var ser = new XmlSerializer(typeof(T));
            //    ser.Serialize(ms, obj);
            //    ms.Position = 0;
            //    objResult = ms.ToArray();
            //}

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
            return listToClone.Select(item => item.Clone()).ToList();
        }
    }
}
