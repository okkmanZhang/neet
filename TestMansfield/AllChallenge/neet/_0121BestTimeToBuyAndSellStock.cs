public class _0121BestTimeToBuyAndSellStock
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
}