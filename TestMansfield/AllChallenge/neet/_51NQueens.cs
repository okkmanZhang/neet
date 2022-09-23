using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _51NQueens
    {

        IList<IList<string>> res = new List<IList<string>>();
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<string> board = Enumerable.Repeat(new string('.', n), n).ToList();
            Backtrack(board, 0);
            return res;
        }

        private void Backtrack(IList<string> board, int row)
        {
            if (row == board.Count())
            {
                res.Add(new List<string>(board));
                return;
            }

            int n = board[row].Count();
            for (int col = 0; col < n; col++)
            {
                if (!IsValid(board, row, col)) continue;

                var boardTemp = board[row].ToCharArray();
                boardTemp[col] = 'Q';
                board[row] = new string(boardTemp);

                Backtrack(board, row + 1);

                boardTemp = board[row].ToCharArray();
                boardTemp[col] = '.';
                board[row] = new string(boardTemp);
            }
        }

        private bool IsValid(IList<string> board, int row, int col)
        {
            int n = board.Count();

            for (int i = 0; i <= row; i++)
            {
                if (board[i][col] == 'Q') return false;
            }

            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (board[i][j] == 'Q') return false;
            }

            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i][j] == 'Q') return false;
            }

            return true;
        }


    }
}
