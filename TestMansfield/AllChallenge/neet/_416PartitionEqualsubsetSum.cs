namespace ClassLibrary1
{
    public class _416PartitionEqualsubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            int sum = 0;
            sum = nums.Sum();

            if (sum % 2 != 0) return false;
            int n = nums.Length;
            sum = sum / 2;

            bool[,] dp = new bool[n + 1, sum + 1];

            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = true;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (j - nums[i - 1] < 0)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, j - nums[i - 1]];
                    }

                }
            }

            return dp[n, sum];
        }
    }
}