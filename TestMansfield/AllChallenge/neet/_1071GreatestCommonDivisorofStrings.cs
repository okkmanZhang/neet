using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _1071GreatestCommonDivisorofStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string strLong = str1.Length >= str2.Length ? str1 : str2;
            string strShort = str1.Length >= str2.Length ? str2 : str1;

            string res = "";

            for (int i = 0; i < strShort.Length; i++)
            {                
                var subString = strShort.Substring(0, i + 1);
                if (IsRepeat(subString))
                {
                    res = subString;
                }
            }

            bool IsRepeat(string str)
            {
                if (strLong.Length % str.Length !=0 || strShort.Length % str.Length != 0)
                {
                    return false;
                }

                StringBuilder temp = new StringBuilder();                
                for(int i =0;i< strLong.Length / str.Length;i++)
                {
                    temp.Append(str);
                }
                if (temp.ToString() != strLong) return false;

                temp.Clear();                
                for (int i = 0; i < strShort.Length / str.Length; i++)
                {
                    temp.Append(str);
                }
                if (temp.ToString() != strShort) return false;

                return true;
            }

            return res;
        }
    }
}
