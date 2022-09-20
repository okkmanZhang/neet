using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _152MaximumProductSubarray
    {
        //brute force O(n*n)
        //Dynamic programming O(n)
        public int MaxProduct(int[] nums)
        {
            int res = int.MinValue;
            int curMin = 1;
            int curMax = 1;

            foreach (int n in nums)
            {
                int temp = curMax * n;
                curMax = Math.Max(Math.Max(n * curMax, n * curMin), n);
                curMin = Math.Min(Math.Min(temp, n * curMin), n);
                res = Math.Max(res, curMax);
            }

            return res;
        }
    }
}
