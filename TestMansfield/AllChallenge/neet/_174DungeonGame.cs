namespace ClassLibrary1
{
    public class _174DungeonGame
    {
        int[,] memo;
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int m = dungeon.Length;
            int n = dungeon[0].Length;
            memo = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    memo[i, j] = -1;
                }
            }

            return DP(dungeon, 0, 0);
        }

        private int DP(int[][] grid, int i, int j)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            if (i == m - 1 && j == n - 1)
            {
                return grid[i][j] >= 0 ? 1 : -grid[i][j] + 1;
            }
            if (i == m || j == n) return int.MaxValue;

            if (memo[i, j] != -1) return memo[i, j];

            int res = Math.Min(DP(grid, i, j + 1), DP(grid, i + 1, j)) - grid[i][j];
            memo[i, j] = res <= 0 ? 1 : res;

            return memo[i, j];
        }
    }
}