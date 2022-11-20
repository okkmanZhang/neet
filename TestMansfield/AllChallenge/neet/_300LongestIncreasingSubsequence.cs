namespace ClassLibrary1
{
    public class _300LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            Array.Fill(dp, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                int maxi = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        maxi = Math.Max(maxi, dp[j]);
                    }
                }

                if (maxi>0) dp[i] = maxi + 1;

            }

            int max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}