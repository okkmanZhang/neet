namespace ClassLibrary1
{
    public class _887SuperEggDrop
    {
        int[,] memo;
        public int SuperEggDrop(int k, int n)
        {
            memo = new int[k + 1, n + 1];
            for (int i = 0; i < k + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    memo[i, j] = -666;
                }
            }

            return DP(k, n);
        }

        private int DP(int k, int n)
        {
            if (k == 1) return n;
            if (n == 0) return 0;

            if (memo[k, n] != -666) return memo[k, n];

            int res = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                res = Math.Min(res, 
                    Math.Max(DP(k, n - i), DP(k - 1, i - 1)) + 1
                    );
            }

            memo[k, n] = res;
            return res;

        }
    }
}