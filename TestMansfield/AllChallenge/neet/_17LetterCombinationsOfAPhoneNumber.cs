using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _17LetterCombinationsOfAPhoneNumber
    {
        //https://leetcode.com/problems/letter-combinations-of-a-phone-number/submissions/
        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, string> digitToChar = new Dictionary<char, string>();
            digitToChar.Add('2', "abc");
            digitToChar.Add('3', "def");
            digitToChar.Add('4', "ghi");
            digitToChar.Add('5', "jkl");
            digitToChar.Add('6', "mno");
            digitToChar.Add('7', "qprs");
            digitToChar.Add('8', "tuv");
            digitToChar.Add('9', "wxyz");
            
            IList<string> res = new List<string>();

            void backTrack (int i, string curStr)
            {
                if(curStr.Length == digits.Length)
                {
                    res.Add(curStr);
                    return;
                }

                foreach(char c in digitToChar[digits[i]])
                {
                    backTrack(i + 1, curStr + c.ToString());
                }
            };


            if (digits.Length > 0)
            {
                backTrack (0, "");
            }

            return res;
        }
    }
}
