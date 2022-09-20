using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _36ValidSudoku
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<char, int> cache = new Dictionary<char, int>();
            bool res = true;

            //row
            for (int i = 0; i < 9; i++)
            {
                cache.Clear();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.') { continue; }

                    if (cache.ContainsKey(board[i][j]))
                    {
                        return false;
                    }
                    else
                    {
                        cache.Add(board[i][j], -1);
                    }
                }
            }

            //column
            for (int i = 0; i < 9; i++)
            {
                cache.Clear();
                for(int j = 0;j < 9; j++)
                {
                    if (board[j][i] == '.') { continue; }

                    if (cache.ContainsKey(board[j][i]))
                    {
                        return false;
                    }
                    else
                    {
                        cache.Add(board[j][i], -1);
                    }
                }
            }

            //subboxes
            int[][] indexs = new int[][] { 
                new int[] { 0, 2, 0, 2 }, 
                new int[] { 0, 2, 3, 5 }, 
                new int[] { 0, 2, 6, 8 }, 
                new int[] { 3, 5, 0, 2 }, 
                new int[] { 3, 5, 3, 5 }, 
                new int[] { 3, 5, 6, 8 }, 
                new int[] { 6, 8, 0, 2 }, 
                new int[] { 6, 8, 3, 5 }, 
                new int[] { 6, 8, 6, 8 },
            };

            for (int i = 0; i < 9; i++)
            {
                if ( !checkSubbox(indexs[i][0], indexs[i][1], indexs[i][2], indexs[i][3])) { return false; }
            }

            bool checkSubbox(int starti,int endi,int startj, int endj) {

                cache.Clear();
                for (int i = starti; i <= endi; i++)
                {
                    for (int j = startj; (j <= endj); j++)
                    {
                        if (board[i][j] == '.') { continue; }

                        if (cache.ContainsKey(board[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            cache.Add(board[i][j], -1);
                        }
                    }
                }

                return true;
            };



            return res;
        }
    }
}
