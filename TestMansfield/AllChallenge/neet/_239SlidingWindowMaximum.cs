using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _239SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {

            IList<int> maxList = new List<int>();
            //slide win to right
            int preMax = int.MinValue;
            for (int j = 0; j < nums.Length; j++)
            {
                if (j + k > nums.Length) break;
                
                int currentMax = int.MinValue;

                if (j > 0 && nums[j - 1] != preMax)
                {
                    currentMax = Math.Max(preMax, nums[j + k - 1]);
                }
                else
                {
                    for (int i = j; i < j + k; i++)
                    {
                        currentMax = Math.Max(currentMax, nums[i]);
                    }
                }

                preMax = currentMax;
                maxList.Add(currentMax);
            }

            //result;
            return maxList.ToArray();
        }
    }
}
