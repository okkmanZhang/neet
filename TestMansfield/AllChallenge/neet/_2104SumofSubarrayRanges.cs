using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class _2104SumofSubarrayRanges
    {
        public long SubArrayRanges(int[] nums)
        {
            long res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int smin = int.MaxValue;
                int smax = int.MinValue;
                for (int j = i; j < nums.Length; j++)
                {
                    smin = Math.Min(smin, nums[j]);
                    smax = Math.Max(smax, nums[j]);
                    res += smax - smin;
                }
            }

            return res;
        }
    }
}
