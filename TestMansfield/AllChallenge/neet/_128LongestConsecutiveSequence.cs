using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _128LongestConsecutiveSequence
    {
        //hashmap
        //visualization
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> cache = new HashSet<int>();
            int longS = 0;
            nums.ToList().ForEach(x => cache.Add(x));

            for(int i=0;i < nums.Length; i++)
            {
                if(cache.Contains(nums[i]-1))
                {
                    continue;
                } else
                {
                    int step = 1;
                    while (cache.Contains(nums[i]+step))
                    {
                        step++;
                    }

                    longS = Math.Max(longS, step);
                }                
            }

            return longS;
        }
    }
}
