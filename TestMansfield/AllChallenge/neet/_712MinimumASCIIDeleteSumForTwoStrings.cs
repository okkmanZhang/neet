namespace ClassLibrary1
{
    public class _712MinimumASCIIDeleteSumForTwoStrings
    {

        int[,] memo;
        public int MinimumDeleteSum(string s1, string s2)
        {
            int m = s1.Length, n = s2.Length;
            memo = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i, j] = -1;
                }
            }

            return DP(s1, 0, s2, 0);

        }

        private int DP(string s1, int i, string s2, int j)
        {
            int res = 0;
            if (i == s1.Length)
            {
                for (; j < s2.Length; j++)
                {
                    res += s2[j];
                }
                return res;
            }
            if (j == s2.Length)
            {
                for (; i < s1.Length; i++)
                {
                    res += s1[i];
                }
                return res;
            }

            if (memo[i, j] != -1) return memo[i, j];

            if (s1[i] == s2[j])
            {
                memo[i, j] = DP(s1, i + 1, s2, j + 1);
            }
            else
            {
                memo[i, j] = Math.Min(s1[i] + DP(s1, i + 1, s2, j), 
                                      s2[j] + DP(s1, i, s2, j + 1));
            }

            return memo[i, j];
        }

    }
}