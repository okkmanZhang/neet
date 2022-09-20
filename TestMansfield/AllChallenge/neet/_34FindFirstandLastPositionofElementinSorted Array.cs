using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _34FindFirstandLastPositionofElementinSorted_Array
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int starting = -1;
            int ending = -1;

            if (nums.Length == 0) { return new int[] { starting, ending }; }
            if (nums.Length == 1)
            {
                if (nums[0] == target)
                { return new int[] { 0, 0 }; }
                else
                {
                    return new int[] { -1, -1 };
                }
            }

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    starting = mid;
                    break;
                }
                else if (nums[mid] > target)
                {
                    right = mid-1;
                }
                else
                {
                    left = mid+1;
                }
            }

            //not found
            if (starting == -1) { return new int[] { -1, -1 }; }

            left = right = starting;

            while(left > 0)
            {
                if (nums[left-1] == target)
                {
                    left--;
                }else
                {
                    break;
                }
            }
            
            while(right < nums.Length -1)
            {
                if(nums[right+1] == target)
                {
                    right++;
                }else
                { break; }
            }


            return new int[] { left, right };
        }
    }
}
