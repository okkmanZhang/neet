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

            for (int i = nums.Length -1; i >= 0; i--)
            {
                if (i + nums[i] >= lastGoodPosition )
                {
                    lastGoodPosition = i;
                }
            }

            return lastGoodPosition == 0;
        }
    }
}


