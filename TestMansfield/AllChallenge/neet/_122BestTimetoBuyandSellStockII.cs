using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _122BestTimetoBuyandSellStockII
    {
        //double pointer (left right)
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;

            int left = 0;
            int right = 0;
            int profit = 0;

            while (left <= prices.Length - 1 && right <= prices.Length - 1)
            {
                if (prices[right] >= prices[left])
                {
                    profit += prices[right] - prices[left];
                    left = right;
                    right++;
                }
                else
                {
                    left = right;
                    right++;
                    continue;
                }
            }

            return profit;

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
                dp[i,1] = Math.Max(dp[i-1,1],dp[i-1,0]-prices[i]);
                
            }

            return dp[n-1,0];            

        }
    }
}
