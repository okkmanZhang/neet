using System.Text;

namespace ClassLibrary1
{
    public class _694NumberOfDistinctIslands
    {
        public int NumDistinctIslands(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            HashSet<string> islands = new HashSet<string>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(grid[i][j]==1)
                    {
                        var sb = new StringBuilder();
                        DFS(i,j,sb,222);
                        islands.Add(sb.ToString());
                    }
                }
            }

            return islands.Count;


            void DFS(int i,int j, StringBuilder sb, int dir)
            {
                if(i<0 || j<0 || i>=m || j>=n || grid[i][j]==0) return;                

                grid[i][j]=0;
                sb.Append(dir).Append(',');
                DFS(i-1,j,sb,1);
                DFS(i+1,j,sb,2);
                DFS(i,j+1,sb,3);
                DFS(i,j-1,sb,4);

                sb.Append(-dir).Append(',');
            }


        }
    }
}