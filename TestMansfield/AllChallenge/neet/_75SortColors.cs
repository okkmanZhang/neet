using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _75SortColors
    {
        public void SortColors(int[] nums)
        {
            if (nums.Length == 1) return;

            int[] xx = Enumerable.Repeat(-1, 3).ToArray();

            for(int i = 0; i< nums.Length; i++)
            {
                if (nums[i] == 0 && xx[0] != 0)
                {
                    xx[0] = 0;
                    continue;
                }
                if (nums[i] == 1 && xx[1] != 1)
                {
                    xx[1] = 1;
                    continue;
                }
                if (nums[i] == 2 && xx[2] != 2)
                {
                    xx[2] = 2;
                    continue;
                }
            }

            int frist = -1;
            int second = -1;

            for(int i = 0; i < xx.Length; i++)
            {
                if (xx[i] != -1 && frist ==-1)
                {
                    frist = xx[i];
                    continue;
                }

                if (xx[i]!= -1 && second ==-1)
                {
                    second = xx[i];
                    continue;
                }
            }

            if (frist == second) return;

            sortBy(second, sortBy( frist, 0) + 1);

            int sortBy(int x, int startIndex)
            {
                int lastIndex = startIndex;                
                int left = startIndex; //position for replace
                int right = startIndex+1; // value = x, will swap with left.

                while(left < nums.Length && right < nums.Length)
                {
                    if (nums[left] == x)
                    {
                        lastIndex = left;
                        left++;
                        continue;
                    }

                    if (right <= left || nums[right] != x )
                    {
                        right++;                        
                        continue;
                    }

                    if (nums[left] != x && nums[right] == x && nums[right] < nums[left] )
                    {
                        int temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                        lastIndex = left;
                    }
                }

                return lastIndex;
                
            }
        }
    }
}
