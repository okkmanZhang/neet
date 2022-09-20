using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _56MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            IList<int[]> res = new List<int[]>();
            Array.Sort<int[]>(intervals, (a, b) =>
            {
                if (a[0] < b[0])
                {
                    return -1;
                }
                else if (a[0] > b[0])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            res.Add(intervals[0]);

            foreach (int[] current in intervals.Skip(1))
            {
                int lastEnd = res.Last()[1];

                if (current[0] <= lastEnd)
                {
                    res.Last()[1] = Math.Max(lastEnd, current[1]);
                } else
                {
                    res.Add(current);
                }
            }

            return res.ToArray();
        }
    }
}
