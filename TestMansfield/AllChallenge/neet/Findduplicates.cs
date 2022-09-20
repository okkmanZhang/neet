using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class Findduplicates
    {
        public int[] Find(int[] nums)
        {
            var numList = nums.ToList();

            var x = numList.Where(n => numList.FindAll(f=> f == n).Count > 1).Distinct().ToArray();

            return x;
        }
    }
}
