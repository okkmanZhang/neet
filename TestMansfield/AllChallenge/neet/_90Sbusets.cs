using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _90Sbusets
    {
        private IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<int> subset = new List<int>();
            Array.Sort(nums);

            Console.WriteLine(string.Join(" ", nums));
            Backtrack(nums, subset, 0);
            return res;
        }

        private void Backtrack(int[] nums, IList<int> subset, int start)
        {
            
            res.Add(new List<int>(subset));

            for(int i=start;i<nums.Length;i++)
            {
                if(i>start && nums[i]==nums[i-1]) continue;

                subset.Add(nums[i]);
                Backtrack(nums,subset, i+1);
                subset.RemoveAt(subset.Count()-1);
            }
        }
    }
}
