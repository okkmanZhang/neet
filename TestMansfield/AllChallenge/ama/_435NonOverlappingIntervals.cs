

namespace ClassLibrary1
{
    public class _435NonOverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            var sorted = intervals.OrderBy(a => a[1]).ToArray();
            int res = 0;
            int end = sorted[0][1];

            foreach (var item in sorted)
            {
                Console.WriteLine(string.Join(" ", item[0],item[1]));
            }

            for (int i = 1; i < sorted.Length; i++)
            {
                 if (sorted[i][0] < end)
                {
                    res++;
                    continue;
                }
                end = sorted[i][1];
            }

            return res;

        }
    }
}