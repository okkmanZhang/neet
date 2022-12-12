namespace ClassLibrary1
{
    public class _1254NumberOfClosedIslands
    {
        public int ClosedIsland(int[][] grid)
        {
            int res = 0;
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < n; i++)
            {
                DFS(0, i);
                DFS(m - 1, i);
            }
            for (int i = 0; i < m; i++)
            {
                DFS(i, 0);
                DFS(i, n - 1);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        res++;
                        DFS(i, j);
                    }
                }
            }

            return res;

            void DFS(int i, int j)
            {
                if (i < 0 || j < 0 || i >= m || j >= n)
                {
                    return;
                }

                if (grid[i][j] == 1) return;

                grid[i][j] = 1;
                DFS(i + 1, j);
                DFS(i, j + 1);
                DFS(i - 1, j);
                DFS(i, j - 1);
            }

        }
    }
}