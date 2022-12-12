using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class _200NumberofIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;
            var visit = new HashSet<(int, int)>();
            var islands = 0;

            void Bfs(int r, int c)
            {
                Queue<(int, int)> q = new Queue<(int, int)>();
                visit.Add((r, c));
                q.Enqueue((r, c));

                while (q.Any())
                {
                    var point = q.Dequeue();
                    (int, int)[] directions = { (1, 0), (-1, 0), (0, 1), (0, -1) };

                    foreach (var direction in directions)
                    {
                        r = direction.Item1 + point.Item1;
                        c = direction.Item2 + point.Item2;

                        if (r >= 0 &&  r < rows && c >=0 && c < cols && grid[r][c] == '1' && !visit.Contains((r, c)))
                        {
                            q.Enqueue((r, c));
                            visit.Add((r, c));
                        }
                    }
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r][c] == '1' && !visit.Contains((r, c)))
                    {
                        Bfs(r, c);
                        islands++;
                    }
                }
            }

            return islands;
        }

        public int NumIslandsDFS(char[][] grid)
        {
            int res =0;
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(grid[i][j]=='1'){
                        res++;
                        DFS(i,j);
                    }
                }
            }

            return res;

            void DFS(int i,int j)
            {
                if(i<0|| j<0 || i>=m ||j>=n)
                {
                    return;
                }

                if (grid[i][j]=='0') return;

                grid[i][j]='0';
                DFS(i+1,j);
                DFS(i,j+1);
                DFS(i-1,j);
                DFS(i,j-1);
            }
        }

    }
}
