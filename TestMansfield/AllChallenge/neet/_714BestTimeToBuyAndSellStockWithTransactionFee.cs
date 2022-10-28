namespace ClassLibrary1
{
    public class _714BestTimeToBuyAndSellStockWithTransactionFee
    {
        public int MaxProfit(int[] prices, int fee)
        {
            int n = prices.Length;
            int[,] dp = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    dp[0, 0] = 0;
                    dp[0, 1] = -prices[i];
                    continue;
                }

                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i] - fee);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i]);

            }

            return dp[n - 1, 0];
        }

    }
}