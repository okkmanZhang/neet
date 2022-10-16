namespace ClassLibrary1
{
    public class _509FIbonacciNumber
    {
        public int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        public int FibMemo(int n)
        {
            int[] memo = new int[n + 1];
            return Help(n);

            int Help(int y)
            {
                if (y == 0) return 0;
                if (y == 1) return 1;

                if (memo[y] != 0) return memo[y];
                memo[y] = Help(y - 1) + Help(y - 2);
                return memo[y];

            }
        }

        public int FIbDP(int n)
        {
            if (n == 0) return 0;
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        public int FibDP2(int n)
        {
            if (n == 0 || n == 1) return n;

            int dp_i_1 = 1, dp_i_2 = 0;
            for (int i = 2; i <= n; i++)
            {
                int dp_i = dp_i_1 + dp_i_2;
                dp_i_2 = dp_i_1;
                dp_i_1 = dp_i;
            }
            return dp_i_1;
        }
    }
}