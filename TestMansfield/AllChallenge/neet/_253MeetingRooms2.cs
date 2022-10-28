namespace ClassLibrary1
{
    public class _253MeetingRooms2
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            int n = intervals.Length;
            int[] begins = new int[n];
            int[] ends = new int[n];

            for (int i = 0; i < n; i++)
            {
                begins[i] = intervals[i][0];
                ends[i] = intervals[i][1];
            }

            Array.Sort(begins);
            Array.Sort(ends);

            int res = 0, beginIndex = 0, endIndex = 0, count = 0; ;
            while (beginIndex < n && endIndex < n)
            {
                if (begins[beginIndex] < ends[endIndex])
                {
                    count++;
                    beginIndex++;
                }
                else
                {
                    count--;
                    endIndex++;
                }
                res = Math.Max(res, count);
            }

            return res;
        }
    }
}