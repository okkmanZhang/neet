using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.ot
{
    public class OtTest
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int res = 1;
            var sortedA = A.ToList()
                            .Where(a => a > 0)
                            .Distinct()
                            .ToList();
            sortedA.Sort();

            for(int i = 0; i< sortedA.Count; i++)
            {
                if (res == sortedA[i])
                {
                    res++;
                } else
                {
                    return res;
                }
            }

            return res;
        }
    }
}
