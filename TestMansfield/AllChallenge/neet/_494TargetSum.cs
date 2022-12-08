namespace ClassLibrary1
{
    public class _494TargetSum
    {
        int res = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            Backtrack(nums, 0, target);
            return res;
        }


        private void Backtrack(int[] nums, int i, int remain)
        {
            if (i == nums.Length)
            {
                if (remain == 0)
                    res++;

                return;
            }

            remain += nums[i];
            Backtrack(nums, i + 1, remain);
            remain -= nums[i];

            remain -= nums[i];
            Backtrack(nums, i + 1, remain);
            remain += nums[i];
        }

        public int FindTargetSumWays2(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            return DP(nums, 0, target);
        }

        Dictionary<string, int> memo = new Dictionary<string, int>();
        private int DP(int[] nums, int i, int remain)
        {
            if (i == nums.Length)
            {
                if (remain == 0) return 1;

                return 0;
            }

            var key = i + "," + remain;
            if (memo.ContainsKey(key)) return memo[key];

            int res = DP(nums, i + 1, remain - nums[i]) + DP(nums, i + 1, remain + nums[i]);
            memo.Add(key, res);
            return res;
        }

    }
}