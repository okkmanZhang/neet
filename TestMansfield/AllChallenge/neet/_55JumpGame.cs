using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _55JumpGame
    {
        //backtrack,dynamic
        public bool CanJump(int[] nums)
        {
            int lastGoodPosition = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lastGoodPosition)
                {
                    lastGoodPosition = i;
                }
            }

            return lastGoodPosition == 0;
        }

        public bool CanJumpGreedy(int[] nums)
        {
            int n = nums.Length;
            int farthest = 0;
            for (int i = 0; i < n - 1; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);
                if (farthest <= i) return false;
            }

            return farthest >= n - 1 ? true : false;
        }

    }
}


