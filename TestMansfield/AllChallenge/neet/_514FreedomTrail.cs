namespace ClassLibrary1
{
    public class _514FreedomTrail
    {
        Dictionary<char, List<int>> charToIndex = new Dictionary<char, List<int>>();
        int[,] memo;
        public int FindRotateSteps(string ring, string key)
        {
            int m = ring.Length;
            int n = key.Length;
            memo = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                var c = ring[i];
                if (!charToIndex.ContainsKey(c))
                {
                    charToIndex.Add(c, new List<int>());
                }
                charToIndex[c].Add(i);
            }

            return DP(ring, 0, key, 0);
        }

        private int DP(string ring, int i, string key, int j)
        {
            if (j == key.Length) return 0;
            if (memo[i, j] != 0) return memo[i, j];

            int n = ring.Length;

            int res = int.MaxValue;

            foreach (var k in charToIndex[key[j]])
            {
                int delta = Math.Abs(k - i);
                delta = Math.Min(delta,n-delta);
                int sub = DP(ring, k, key, j + 1);
                res = Math.Min(res, 1 + delta + sub);
            }

            memo[i, j] = res;
            return res;
        }
    }
}