using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _130SurroundedRegions
    {
        //DFS
        //reverse thinking
        public void Solve(char[][] board)
        {
            int height = board.Length;
            int length = board[0].Length;

            for(int i =0; i< height;i++)
            {
                for(int j=0; j< length; j++)
                {
                    if (board[i][j] == 'O' && ( i ==0 || i== height-1 || j ==0 || j == length-1 ))
                    {
                        captureDFS(i, j);
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (board[i][j] == 'T')
                    {
                        board[i][j] = 'O';
                    }
                }
            }

            void captureDFS(int h, int l )
            {
                if(h<0 || l <0 || h== height || l ==length || board[h][l] !='O')
                {
                    return;
                }

                board[h][l] = 'T';
                captureDFS(h + 1, l);
                captureDFS(h - 1, l);
                captureDFS(h , l+1);
                captureDFS(h , l-1);
            }
        }
    }
}
