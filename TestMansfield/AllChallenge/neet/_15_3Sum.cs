using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _15_3Sum
    {
        //https://www.youtube.com/watch?v=jzZsG8n2R9A&ab_channel=NeetCode
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> res = new List<IList<int>>();
            var numsList = nums.ToList();
            numsList.Sort();

            int i = 0;
            foreach (int num in numsList)
            {
                if (i>0 && num == numsList[i - 1]) { i++; continue; }

                int left = i +1;
                int right = numsList.Count - 1;

                while( left < right )
                {
                    int _3Sum = num + numsList[left] + numsList[right];
                    if( _3Sum > 0 )
                    {
                        right--;
                    } else if ( _3Sum < 0 )
                    {
                        left++;
                    } else { 
                        res.Add(new List<int>() { num, numsList[left], numsList[right] });
                        left++;
                        while(numsList[left] == numsList[left -1] && left < right)
                        {
                            left++;
                        }
                    }
                }

                i++;
            }

            return res;         
        }
    }
}
