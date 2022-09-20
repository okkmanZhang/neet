using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _79WordSearch
    {
        //backtrack 
        public bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            HashSet<string> path = new HashSet<string>();

            bool dfs(int r, int c , int i)
            {
                if (i == word.Length)
                    return true;

                if (r< 0 || c<0 || r >= rows || c >= cols || word[i] != board[r][c] || path.Contains(string.Join(',',r,c)))
                {
                    return false;
                }

                path.Add(string.Join(',', r, c));

                bool res = dfs(r + 1, c, i + 1) ||
                            dfs(r - 1, c, i + 1) ||
                            dfs(r, c + 1, i + 1) ||
                            dfs(r, c - 1, i + 1);

                path.Remove(string.Join(',', r, c));
                return res;
            }

            for (int i = 0; i< rows;i++)
            {
                for(int j = 0; j<cols;j++)
                {
                    if(dfs(i,j,0))
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
