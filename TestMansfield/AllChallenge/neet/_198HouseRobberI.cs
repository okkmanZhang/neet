namespace ClassLibrary1
{
    public class _198HouseRobberI
    {
        public int Rob(int[] nums)
        {
            int[] memo = new int[nums.Length];
            Array.Fill(memo, -1);

            return Dp(nums, 0, memo);

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