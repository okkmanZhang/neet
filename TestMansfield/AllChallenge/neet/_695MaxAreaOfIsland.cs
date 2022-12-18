namespace ClassLibrary1
{
    public class _695MaxAreaOfIsland
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            int res = 0;
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        res = Math.Max(res, DFS(i, j));
                    }
                }
            }

            return res;

            int DFS(int i, int j)
            {
                if (i < 0 || j < 0 || i >= m || j >= n)
                {
                    return 0;
                }

                if (grid[i][j] == 0) return 0;

                grid[i][j] = 0;

                return DFS(i + 1, j) +
                 DFS(i, j + 1) +
                 DFS(i - 1, j) +
                 DFS(i, j - 1) + 1;
            }
        }
    }
}