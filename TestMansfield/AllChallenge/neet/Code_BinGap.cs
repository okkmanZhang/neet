using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class Code_BinGap
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            string binary = Convert.ToString(N, 2);

            int left = -1;            
            int current = 0;
            int res = 0;

            while (left < binary.Length && current < binary.Length)
            {

                if (binary[current] == '1' && left == -1)
                {
                    left = current;
                }

                if (binary[current] == '1' && left > -1 && current - left > 1)
                {                    
                    res = Math.Max(res, current - left - 1);
                    left = current;
                }else if (binary[current] == '1' && left > -1 && current - left == 1)
                {
                    left = current;
                }


                current++;
            }

            return res;
        }

    }
}
