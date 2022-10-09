using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    internal class _926_FlipStringtoMonotoneIncreasing
    {
        public int MinFlipsMonoIncr(string s)
        {
            int one = 0;
            int zero = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                { one++; }
                else
                {
                    zero++;
                }
                zero = Math.Min(zero, one);
            }
            return zero;
        }
    }
}
