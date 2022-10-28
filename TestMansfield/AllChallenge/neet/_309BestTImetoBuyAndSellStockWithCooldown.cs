namespace ClassLibrary1
{
    public class _309BestTImetoBuyAndSellStockWithCooldown
    {
        public int MaxProfit(int[] prices)
        {
            int n = prices.Length;
            int[,] dp = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                if (i - 1 == -1)
                {
                    dp[i, 0] = 0;
                    dp[i, 1] = -prices[i];
                    continue;
                }

                if (i - 2 == -1)
                {
                    dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                    dp[i, 1] = Math.Max(dp[i - 1, 1], -prices[i]);
                    continue;
                }

                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 2, 0] - prices[i]);

            }

            return dp[n - 1, 0];
        }
    }
}