using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _162FindPeakElement
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length == 1) return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 && nums[i] > nums[i + 1])
                {
                    return i;
                }

                if (i == nums.Length - 1 && nums[nums.Length - 1] > nums[nums.Length - 2])
                {
                    return i;
                }

                if (nums[i] > nums[i + 1] && nums[i] > nums[i - 1])
                { return i; }
            }

            return 0;
        }
    }
}
