namespace ClassLibrary1
{
    public class _213HouseRobberII
    {
        public int Rob(int[] nums)
        {
            if (nums.Length==1) return nums[0];

            int[] memo1 = new int[nums.Length];
            int[] memo2 = new int[nums.Length];
            Array.Fill(memo1, -1);
            Array.Fill(memo2, -1);

            return Math.Max(  Dp(nums.Skip(1).ToArray(), 0, memo1), Dp(nums.SkipLast(1).ToArray(), 0, memo2));

        }

        private int Dp(int[] nums, int start, int[] memo)
        {
            if (start >= nums.Length) return 0;

            if (memo[start] != -1) return memo[start];

            int res = Math.Max(
                Dp(nums, start + 1, memo),
                nums[start] + Dp(nums, start + 2, memo));

            memo[start] = res;

            return res;
        }
    }
}