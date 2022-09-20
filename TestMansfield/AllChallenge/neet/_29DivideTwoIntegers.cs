using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _29DivideTwoIntegers
    {
        //https://medium.com/@nischalbohara77/binary-representation-of-integers-bc7f52c21202
        //https://docs.microsoft.com/en-us/dotnet/api/system.int32?redirectedfrom=MSDN&view=net-6.0
        //https://www.youtube.com/watch?v=htX69j1jf5U&ab_channel=NideeshTerapalli
        public int Divide(int dividend, int divisor)
        {
            if(dividend == 1 << 31 && divisor == -1) return int.MaxValue;
            //if(dividend == 1 << 31 && divisor == 1) return int.MinValue;

            bool sign = (dividend >=0) == (divisor >= 0) ? true : false;
            
            long temp = dividend;
            long temp2 = divisor;

            long dividend2 = Math.Abs(temp);
            long divisor2 = Math.Abs(temp2);

            int result = 0;

            while(dividend2 - divisor2 >= 0)
            {
                int count = 0;
                while(dividend2 - (divisor2 <<1 << count) >=0)
                {
                    count++;
                }

                result += 1 << count;
                dividend2 -= divisor2 << count;
            }

            return sign?result:-result;
        }
    }
}
