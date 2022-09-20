using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _38CountandSay
    {
        public string CountAndSay(int n)
        {


            string inCount(int n)
            {
                IList<int[]> res = new List<int[]>();
                if (n == 1) return "1";

                string x = inCount(n-1);
                int temp = -1;
                int[] tempA = null;
                for(int i = 0; i < x.Length; i++)
                {
                    int xi = Convert.ToInt32(x[i].ToString());

                    if(temp != xi)
                    {
                        tempA = new int[] { 1, xi };
                        res.Add(tempA);
                        temp = xi;
                    } else
                    {                        
                        tempA[0] = tempA[0] + 1;                        
                    }
                }

                string y = "";
                foreach(int[] say in res)
                {
                    y += $"{say[0]}{say[1]}";
                }
                return y;
            }
            
            return inCount(n);
        }
    }
}
