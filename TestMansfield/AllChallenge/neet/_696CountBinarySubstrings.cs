using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class _696CountBinarySubstrings
    {
        public int CountBinarySubstrings(string s)
        {
            if (s.Length <= 1) return 0;

            int res = 0;
            int start = 0;
            int end = 0;
            int i = 1;
            //int last = 0;

            while(i <=s.Length)
            {
                if(i == s.Length || s[i-1] != s[i])
                {
                    res += Math.Min(
                        s.Substring(start, i - start).Where(s => s == '0').Count(),
                        s.Substring(start, i - start).Where(s => s == '1').Count());

                    start = end;
                    end = i;
                }else
                {
                    //res++;
                }

                i++;
            }
            return res;

        }
    }
}
