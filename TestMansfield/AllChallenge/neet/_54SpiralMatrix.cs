using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _54SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {

            int m = matrix.Length;
            int n = matrix[0].Length;

            int left = 0, top = 0;
            int right =n, bottom = m;

            List<int> res = new List<int>();


            while(left < right && top < bottom)
            {
                for(int i = left; i < right; i++)
                {
                    res.Add(matrix[top][i]);
                }
                top++;

                for(int i = top; i < bottom ; i++)
                {
                    res.Add(matrix[i][right - 1]);
                }
                right--;

                if (!(left < right && top < bottom))
                    break;

                for(int i = right -1; i > left-1  ; i--)
                {
                    res.Add((matrix[bottom - 1][i]));
                }
                bottom--;

                for(int i = bottom -1;i >top-1  ; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left++;
            }

            return res;

        }
    }
}
