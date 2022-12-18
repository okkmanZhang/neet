public class _877StoneGame
{
    public bool StoneGame(int[] piles)
    {
        return true;

    }

namespace ClassLibrary1
{
    public class _877StoneGame
    {

        private class Pair
        {
            public int fir, sec;
            public Pair(int fir, int sec)
            {
                this.fir = fir;
                this.sec = sec;
            }
        }
        public bool StoneGame(int[] piles)
        {
            int n = piles.Length;
            Pair[,] dp = new Pair[n, n];

            for (int i = 0; i < n; i++)
            {
                dp[i, i] = new Pair(piles[i], 0);
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int left = piles[i] + dp[i + 1, j].sec;
                    int right = piles[j] + dp[i, j - 1].sec;

                    if (left > right)
                    {
                        dp[i, j] = new Pair(left, dp[i + 1, j].fir);
                    }
                    else
                    {
                        dp[i, j] = new Pair(right, dp[i, j - 1].fir);
                    }

                }
            }
            var res = dp[0, n - 1];
            return res.fir - res.sec >= 0 ? true : false;
        }

    }
}