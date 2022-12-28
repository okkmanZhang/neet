namespace ClassLibrary1
{
    public class _1288RemoveCoveredIntervals
    {
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) =>
            {
                if (a[0] == b[0])
                    return b[1] - a[1];

                return a[0] - b[0];
            });

            int l = intervals[0][0];
            int r = intervals[0][1];

            int res = 0;
            for (int i = 1; i < intervals.Length; i++)
            {
                int[] intv = intervals[i];

                if (l <= intv[0] && r >= intv[1])
                {
                    res++;
                }

                if (r >= intv[0] && r <= intv[1])
                {
                    r = intv[1];
                }

                if (r < intv[0])
                {
                    l = intv[0];
                    r = intv[1];
                }
            }

            return  intervals.Length - res;
        }
    }
}