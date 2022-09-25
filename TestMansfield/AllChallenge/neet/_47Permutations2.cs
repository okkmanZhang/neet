namespace ClassLibrary1
{
    public class _47Permutations2
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<int> track = new List<int>();
            IList<bool> used = Enumerable.Repeat(false, nums.Count()).ToList();
            Array.Sort(nums);
            Backtrack(nums, track,used);
            return res;
        }

        private void Backtrack(int[] nums, IList<int> track,  IList<bool> used)
        {
            if (track.Count() == nums.Count())
            {
                res.Add(new List<int>(track));
                return;
            }

            for (int i = 0; i < nums.Count(); i++)
            {
                if (i > 0 && nums[i] == nums[i - 1] && !used[i-1])
                {
                    continue;
                }

                if (used[i]) continue;

                used[i]=true;
                track.Add(nums[i]);
                Backtrack(nums, track,used);
                track.RemoveAt(track.Count() - 1);
                used[i]=false;
            }
        }
    }
}