using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _166FractiontoRecurringDecimal
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0) return "0";
            StringBuilder sb = new StringBuilder();
            if ((numerator < 0 && denominator > 0)
                || (numerator > 0 && denominator < 0))
            {
                sb.Append("-");
            }
            long divisor = Math.Abs((long)numerator);
            long dividend = Math.Abs((long)denominator);
            long remainder = divisor % dividend;
            sb.Append(divisor / dividend);

            if (remainder == 0)
            {
                return sb.ToString();
            }
            sb.Append(".");
            Dictionary<long, int> map = new Dictionary<long, int>();
            while (remainder != 0)
            {
                if (map.ContainsKey(remainder))
                {
                    sb.Insert(map[remainder], "(");
                    sb.Append(")");
                    break;
                }
                map.Add(remainder, sb.Length);
                remainder *= 10;
                sb.Append(remainder / dividend);
                remainder %= dividend;
            }

            return sb.ToString();
        }
    }
}
