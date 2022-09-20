using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _8StringToInteger
    {
        public int MyAtoi(string s)
        {
            if(s.Length == 0) { return 0; }

            bool isNegative = false;
            bool isStart = false;
            List<char> digits = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && !isStart) { continue; }
                if (s[i] == ' ' && isStart) { break; }

                if (s[i] == '-' && !isStart) 
                { 
                    isNegative = true;
                    isStart = true;
                    continue;
                }
                if (s[i] == '+' && !isStart)
                {
                    isNegative = false;
                    isStart = true;
                    continue;
                }

                if ((s[i] == '+' || s[i] == '-') && isStart)
                {
                    break;
                }

                if (s[i] < '0' || s[i] > '9')
                {
                    break;
                }

                if (s[i] >= '0' && s[i] <= '9' )
                {
                    digits.Add(s[i]);
                    isStart = true;
                    continue;
                }

            }

            if (digits.Count == 0) { digits.Add('0'); }

            bool isOverflow = !Int32.TryParse(digits.ToArray(), out int y);

            if(!isNegative && !isOverflow)
            {
                return y;
            }
            if (!isNegative && isOverflow)
            {
                return Int32.MaxValue;
            }
            if (isNegative && !isOverflow)
            {
                return -1 * y;
            }
            if (isNegative && isOverflow)
            {
                return Int32.MinValue;
            }

            return 0;
        }
    }
}
