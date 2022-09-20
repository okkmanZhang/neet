using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _48RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int len = matrix.Length;
            if(len == 1) { return; }

            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    string newkey = $"{j}-{len - 1 - i}";
                    string oldkey = $"{i}-{j}";

                    if( !map.ContainsKey(newkey))
                    {
                        map.Add(newkey, matrix[j][len - 1 - i]);
                    }

                    int dd = map.ContainsKey(oldkey) ? map[oldkey] : matrix[i][j];

                    matrix[j][len-1-i] = dd;
                }
            }            
        }
    }
}
