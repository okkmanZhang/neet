namespace ClassLibrary1
{
    public class _322CoinChange
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] memo = new int[amount+1];
            Array.Fill(memo, -2);

            return Dp(coins, amount);

            int Dp(int[] dpCoins, int dpAmount)
            {
                if (dpAmount == 0) return 0;
                if (dpAmount < 0) return -1;

                int res = int.MaxValue;
                foreach (var item in dpCoins)
                {
                    if ((dpAmount - item) < 0 ) continue;

                    int subProblem = memo[dpAmount - item] == -2 
                        ? Dp(dpCoins, dpAmount - item) : memo[dpAmount - item];
                    if (subProblem == -1) continue;

                    res = Math.Min(res, subProblem + 1);
                }
                memo[dpAmount] = res == int.MaxValue ? -1 : res;
                return memo[dpAmount];
            }
        }
    }
}