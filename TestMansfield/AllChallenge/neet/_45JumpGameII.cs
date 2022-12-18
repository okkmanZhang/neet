namespace ClassLibrary1
{
    public class _45JumpGameII
    {
        int[] memo;
        public int Jump(int[] nums)
        {
            int n = nums.Length;
            memo = new int[n];

            Array.Fill(memo, n);
            return DP(nums, 0);
        }

        private int DP(int[] nums, int p)
        {
            int n = nums.Length;
            if (p >= n - 1)
            {
                return 0;
            }
            if (memo[p] != n) return memo[p];

            int steps = nums[p];
            for (int i = 1; i <= steps; i++)
            {
                int sub = DP(nums, p + i);
                memo[p] = Math.Min(memo[p], sub + 1);
            }

            return memo[p];
        }

        public int JumpGreedy(int[] nums)
        {
            int n = nums.Length;
            int end = 0, farthest = 0;
            int jumps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                farthest = Math.Max(nums[i] + i, farthest);
                if (end == i)
                {
                    jumps++;
                    end = farthest;
                }
            }

            return jumps;
        }
    }
}