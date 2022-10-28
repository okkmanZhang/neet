public class _121BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        int min = 0;
        int prf = 0;

        for (int i = 0; i < prices.Length -1; i++)
        {
            if (i == 0)
                min = prices[i];

            if (i > 0 && prices[i] < min) {
                min = prices[i];
            }
            
            prf = Math.Max(prf, prices[i+1] - min);

            Console.WriteLine($"{i}:{min}:{prf}");
        }


        return prf;
    }

    public int MaxProfitDp(int[] prices)
    {
        int n = prices.Length;
        int[,] dp = new int[n,2];

        for (int i = 0; i < n; i++)
        {
            if(i==0)
            {
                dp[0,0] = 0;
                dp[0,1] = -prices[i];
                continue;
            }

            dp[i,0] = Math.Max(dp[i-1,0], dp[i-1,1]+prices[i]);
            dp[i,1] = Math.Max(dp[i-1,1],-prices[i]);
            
        }

        return dp[n-1,0];
    }
}