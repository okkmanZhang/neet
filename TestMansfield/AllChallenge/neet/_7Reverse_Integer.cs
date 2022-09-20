using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _7Reverse_Integer
    {
        public int Reverse(int x)
        {
            bool isNegtive = false;
            if (x < 0)
            {
                isNegtive = true;
                x = x * -1;
            } else if (x > 0)
            {
                isNegtive = false;
            } else
            {
                return 0;
            }
            
            var xStr = x.ToString().ToArray();

            // 4 -> 2, 5 -> 3
            // 3    1  4     2
            int mid = xStr.Length % 2 == 0 ? xStr.Length / 2 : xStr.Length / 2 + 1;

            for(int i = 0; i < mid; i++)
            {
                char temp = xStr[i];
                xStr[i] = xStr[xStr.Length - 1 - i];
                xStr[xStr.Length - 1 - i] = temp;
            }

            int y=0;
            bool isOverflow = !Int32.TryParse(String.Join("", xStr), out y);
            if ( !isNegtive && isOverflow)
            {
                return 0;
            }


            return isNegtive ? -1 * y : y;
        }
    }
}
