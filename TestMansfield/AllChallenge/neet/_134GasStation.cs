using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _134GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {

            if (gas.Length == 1)
            {
                if (gas[0] < cost[0])
                    return -1;
                else
                    return 0;
            }
            
            int len = gas.Length;

            int getCostIndex(int gasIndex)
            {                
                if (gasIndex == 0) return len - 1;

                return gasIndex - 1;
            }

            for (int i=0;i<len;i++)
            {
                if (cost[i]>=gas[i]) { continue; }
                   
                int j = i;
                int gasCarried = 0;
                int step = 0;                
                while(step <= len)
                {
                    if ( step ==0 && j == i)
                        gasCarried = gas[j];
                    else
                    {
                        if (gasCarried < cost[getCostIndex(j)]) break;

                        gasCarried = gasCarried + gas[j] - cost[getCostIndex(j)];
                    }

                    if (gasCarried <= 0) { break; }


                    if (j == len - 1)
                        j = 0;
                    else
                        j++;                    

                    step++;
                }

                if (step > len) return i;
            }

            return -1;
        }
    }
}
