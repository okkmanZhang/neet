using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _46Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {

            IList<IList<int>> GetPermute(int[] subNums)
            {
                if (subNums.Length == 1) { return new List<IList<int>>() { new List<int>() { subNums[0] } }; }

                IList<IList<int>> res = new List<IList<int>>();
                int first = subNums[0];
                int[] restNums = new int[subNums.Length - 1];
                Array.Copy(subNums, 1, restNums, 0, subNums.Length - 1);

                IList<IList<int>> lastRes = GetPermute(restNums);

                foreach (IList<int> lastItem in lastRes)
                {
                    for (int i = 0; i < subNums.Length; i++)
                    {
                        var newItem = lastItem.ToArray();
                        var newList = newItem.ToList();
                        newList.Insert(i, first);
                        res.Add(newList);
                    }
                }

                return res;
            }

            return GetPermute(nums);
        }

        #region backtrack
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> BacktrackMain(int[] nums)
        {
            IList<int> track = new List<int>();
            Boolean[] used = new Boolean[nums.Length];
            Backtrack(nums, track, used);

            return res;
        }

        private void Backtrack(int[] nums, IList<int> track, Boolean[] used)
        {
            if (track.Count() == nums.Length)
            {
                res.Add(new List<int>(track));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;

                track.Add(nums[i]);
                used[i] = true;
                Backtrack(nums, track, used);
                track.RemoveAt(track.Count() - 1);
                used[i]=false;
            }
        }
        #endregion
    }
}
