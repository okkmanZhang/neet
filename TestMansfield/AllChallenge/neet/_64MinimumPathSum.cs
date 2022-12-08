namespace ClassLibrary1
{
    public class _64MinimumPathSum
    {
        int[,] memo;
        public int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            memo = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i, j] = -1;
                }
            }

            return DP(grid, m - 1, n - 1);
        }

        private int DP(int[][] grid, int i, int j)
        {
            if (i == 0 && j == 0) return grid[0][0];

            if (i < 0 || j < 0)
            {
                return int.MaxValue;
            }

            if (memo[i, j] != -1) return memo[i, j];

            memo[i, j] = Math.Min(DP(grid, i - 1, j), DP(grid, i, j - 1)) + grid[i][j];

            return memo[i,j];
        }
    }
}