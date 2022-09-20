using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _73SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            int height = matrix.Length;
            int length = matrix[0].Length;

            Dictionary<string, int> updated = new Dictionary<string, int>();

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < length; j++)
                {
                    if (updated.ContainsKey($"{i}-{j}")) continue;

                    if (matrix[i][j] == 0)
                    {
                        setRowColumnToZero(i, j);
                        break;
                    }
                }
            }

            void setRowColumnToZero(int h, int l)
            {
                for (int i = 0;i < length; i++)
                {
                    if (matrix[h][i] != 0 && !updated.ContainsKey($"{h}-{i}")) 
                    { 
                        updated.Add($"{h}-{i}", 0); 
                    }
                    matrix[h][i] = 0;
                }

                for (int j = 0; j < height; j++)
                {
                    if (matrix[j][l] != 0 && !updated.ContainsKey($"{j}-{l}")) 
                    { 
                        updated.Add($"{j}-{l}", 0); 
                    }
                    matrix[j][l] = 0;
                }
            }

        }
    }
}
