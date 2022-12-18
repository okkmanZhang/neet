namespace ClassLibrary1
{
    public class _10RegularExpressionMatching
    {

        int[,] memo;
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;
            memo = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i, j] = -2;
                }

            }

            return DP(s, 0, p, 0);
        }

        private bool DP(string s, int i, string p, int j)
        {
            int m = s.Length;
            int n = p.Length;

            if (j == n)
            {
                return i == m;
            }

            if (i == m)
            {
                if ((n - j) % 2 == 1) return false;

                for (; j + 1 < n; j += 2)
                {
                    if (p[j + 1] != '*') return false;

                }

                return true;
            }

            if (memo[i, j] != -2) return memo[i, j] == 0 ? false : true;

            bool res = false;

            if (s[i] == p[j] || p[j] == '.')
            {
                if (j < n - 1 && p[j + 1] == '*')
                {
                    res = DP(s, i, p, j + 2) || DP(s, i + 1, p, j);
                }
                else
                {
                    res = DP(s, i + 1, p, j + 1);
                }
            }
            else
            {
                if (j < n - 1 && p[j + 1] == '*')
                {
                    res = DP(s, i, p, j + 2);

                }
                else
                {
                    res = false;
                }
            }
            memo[i, j] = res ? 1 : 0;
            return res;
        }

    }
}