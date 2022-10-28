using System;

namespace ClassLibrary1
{
    public class _452MinimumNumberOfArrowsToBurstBalloons
    {
        public int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (a, b) => a[1] < b[1] ? -1 : a[1] == b[1] ? 0 : 1);

            int res = 1;
            int end = points[0][1];



            for (int i = 1; i < points.Length; i++)
            {
                if (end < points[i][0])
                {
                    res++;
                    end = points[i][1];
                }

            }

            return res;
        }
    }
}