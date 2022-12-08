namespace ClassLibrary1
{
    public class _651FourKeysKeyboard
    {
        public int MaxA(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] + 1;
                for (int j = 2; j < i; j++)
                {
                    dp[i] = Math.Max(dp[i], dp[j - 2] * (i - j + 1));
                }
            }
            return dp[n];

        }
    }
}