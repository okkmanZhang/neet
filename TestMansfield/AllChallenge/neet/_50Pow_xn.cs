using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _50Pow_xn
    {
        public double MyPow(double x, int n)
        {
            long nn = n;
            if (x == 1) { return Convert.ToDouble(1.ToString("0.00000")); }
            if (x == -1) { return Convert.ToDouble((1 * ((Math.Abs(nn) % 2 == 0) ? 1 : -1)).ToString("0.00000")); }
            if (n == int.MinValue) { return Convert.ToDouble(0.ToString("0.00000")); }

            double res = 1;

            if(n >0)
            {
                for(int i = 0; i < n; i++)
                {
                    res *= x;
                }
            } else
            {
                if (n == int.MinValue)
                {
                    for (int i = 0; i < Math.Abs(n+1); i++)
                    {
                        res *= 1 / x;
                    }
                    res *= 1 / x;

                }else
                {
                    for (int i = 0; i < Math.Abs(n); i++)
                    {
                        res *= 1 / x;
                    }
                }
            }

            return Convert.ToDouble( res.ToString("0.00000"));
        }
    }
}
