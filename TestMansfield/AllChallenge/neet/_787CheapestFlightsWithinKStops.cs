namespace ClassLibrary1
{
    public class _787CheapestFlightsWithinKStops
    {
        Dictionary<int, List<int[]>> indegree;
        int src, dst;
        int[,] memo;
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            k++;
            this.src = src;
            this.dst = dst;

            memo = new int[n, k + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k + 1; j++)
                {
                    memo[i, j] = -999;
                }
            }

            indegree = new Dictionary<int, List<int[]>>();
            foreach (var item in flights)
            {
                int from = item[0];
                int to = item[1];
                int price = item[2];

                if (!indegree.ContainsKey(to)) indegree.Add(to, new List<int[]>());

                indegree[to].Add(new int[] { from, price });
            }

            return DP(dst, k);
        }

        private int DP(int s, int k)
        {
            if (s == src) return 0;
            if (k == 0) return -1;

            if (memo[s, k] != -999) return memo[s, k];

            int res = int.MaxValue;
            if (indegree.ContainsKey(s))
            {
                foreach (var item in indegree[s])
                {
                    int from = item[0];
                    int price = item[1];
                    int sub = DP(from, k - 1);
                    if (sub != -1) res = Math.Min(res, sub + price);
                }
            }

            memo[s, k] = res == int.MaxValue ? -1 : res;
            return memo[s, k];
        }
    }
}