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

            while( left<= prices.Length -1 && right <= prices.Length - 1)
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
    }
}
