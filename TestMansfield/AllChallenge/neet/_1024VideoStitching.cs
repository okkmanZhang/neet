namespace ClassLibrary1
{
    public class _1024VideoStitching
    {
        public int VideoStitching(int[][] clips, int time)
        {
            Array.Sort(clips, (a, b) =>
            {
                if (a[0] == b[0])
                {
                    return b[1] - a[1];
                }
                return a[0] - b[0];
            });


            int res = 0;
            int curEnd = 0, nextEnd = 0;
            int i = 0, n = clips.Length;

            while (i < n && clips[i][0] <= curEnd)
            {
                while (i < n && clips[i][0] <= curEnd)
                {
                    nextEnd = Math.Max(nextEnd, clips[i][1]);
                    i++;
                }
                res++;
                curEnd = nextEnd;
                if (curEnd >= time) return res;
            }

            return -1;

        }
    }
}