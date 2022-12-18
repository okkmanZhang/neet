namespace ClassLibrary1
{
    public class _72EditDistance
    {
        int[,] memo;
        public int MinDistance(string word1, string word2)
        {
            int m = word1.Length, n = word2.Length;
            memo = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i,j]=-1;
                }
            }

            return DP(word1, m - 1, word2, n - 1);
        }

        private int DP(string s1, int i, string s2, int j)
        {
            if (i == -1) return j + 1;
            if (j == -1) return i + 1;

            if (memo[i,j] != -1) return memo[i,j];

            if (s1[i] == s2[j])
            {
                memo[i,j] = DP(s1, i - 1, s2, j - 1);                
            } else {

                memo[i,j] = Min(
                    DP(s1, i, s2, j - 1) + 1,
                    DP(s1, i - 1, s2, j) + 1,
                    DP(s1, i - 1, s2, j - 1) + 1
                );
            }

            return memo[i,j];

        }

        private int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}