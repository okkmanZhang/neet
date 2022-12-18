namespace ClassLibrary1
{
    public class _583DeleteOperationForTwoStrings
    {

        public int MinDistance(string word1, string word2)
        {
            int lcs = LongestCommonSubsequence(word1,word2);
            return word1.Length - lcs + word2.Length - lcs;
        }

        int[,] memo;
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int m = text1.Length, n = text2.Length;
            memo = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i, j] = -1;
                }
            }

            return DP(text1, 0, text2, 0);
        }

        private int DP(string s1, int i, string s2, int j)
        {
            if (i == s1.Length || j == s2.Length) return 0;

            if (memo[i, j] != -1) return memo[i, j];

            if (s1[i] == s2[j])
            {
                memo[i, j] = 1 + DP(s1, i + 1, s2, j + 1);
            }
            else
            {
                memo[i, j] = Math.Max(DP(s1, i + 1, s2, j), DP(s1, i, s2, j + 1));
            }

            return memo[i, j];
        }

    }
}