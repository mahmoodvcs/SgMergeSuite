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
using System.Text.RegularExpressions;

namespace SgMergeSuite.Code.Helpers
{
    public static class ExtentionMethods
    {
        public static string ReplaceAllItems(this string strInput, string strFindWhat, string strReplaceWith)
        {
            RegexOptions opt = RegexOptions.IgnoreCase;
            var reg = new Regex(strFindWhat, opt);
            var strReplaceResult = reg.Replace(strInput, strReplaceWith);
            return strReplaceResult;
        }
    }
}
