namespace ClassLibrary1
{
    public class _1905CountSubIslands
    {
        public int CountSubIslands(int[][] grid1, int[][] grid2)
        {
            int res = 0;
            int m = grid1.Length;
            int n = grid1[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid1[i][j] == 0 && grid2[i][j] == 1)
                    {
                        DFS(grid2, i, j);
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid2[i][j] == 1)
                    {
                        res++;
                        DFS(grid2, i, j);
                    }
                }
            }

            return res;


            void DFS(int[][] grid, int i, int j)
            {
                if (i < 0 || j < 0 || i >= m || j >= n)
                {
                    return;
                }

                if (grid[i][j] == 0) return;

                grid[i][j] = 0;
                DFS(grid, i + 1, j);
                DFS(grid, i, j + 1);
                DFS(grid, i - 1, j);
                DFS(grid, i, j - 1);
            }
        }
    }
}