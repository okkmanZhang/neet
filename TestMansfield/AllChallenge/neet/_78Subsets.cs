using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _78Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> f(int[] nums)
            {
                IList<IList<int>> res = new List<IList<int>>();

                if (nums.Length == 0) 
                { 
                    res.Add(new List<int> { });
                    return res;
                }
                if (nums.Length == 1)
                {
                    res.Add(new List<int> { });
                    res.Add(nums);
                    return res;
                }


                IList<IList<int>> pre = f(nums.Take(nums.Length - 1).ToArray());

                foreach (IList<int> l in pre)
                {
                    res.Add(l);
                    int[] y = l.ToArray();
                    var yy = y.ToList();
                    yy.Add(nums.Last());
                    res.Add(yy);
                }

                return res;
            }

            return f(nums);
        }
    }
}
