namespace ClassLibrary1
{
    public class ExamRoom
    {
        private Dictionary<int, int[]> startMap;
        private Dictionary<int, int[]> endMap;
        private SortedSet<int[]> pq;
        private int N;
        public ExamRoom(int N)
        {
            this.N = N;

            startMap = new Dictionary<int, int[]>();
            endMap = new Dictionary<int, int[]>();

            pq = new SortedSet<int[]>(Comparer<int[]>.Create((a, b) =>
            {
                int distA = distance(a);
                int distB = distance(b);
                if (distA == distB) return b[0] - a[0];


                return distA - distB;
            }));

            addInterval(new int[] { -1, N });
        }

        private void removeInterval(int[] intv)
        {
            pq.Remove(intv);
            startMap.Remove(intv[0]);
            endMap.Remove(intv[1]);
        }

        private void addInterval(int[] intv)
        {
            pq.Add(intv);
            startMap.Add(intv[0], intv);
            endMap.Add(intv[1], intv);
        }

        private int distance(int[] intv)
        {
            int x = intv[0];
            int y = intv[1];
            if (x == -1) return y;
            if (y == N) return N - 1 - x;

            return (y - x) / 2;
        }

        public int Seat()
        {
            int[] longest = pq.Last();
            int x = longest[0], y = longest[1];
            int seat;
            if (x == -1)
            {
                seat = 0;
            }
            else if (y == N)
            {
                seat = N - 1;
            }
            else
            {
                seat = (y - x) / 2 + x;
            }

            int[] left = new int[] { x, seat };
            int[] right = new int[] { seat, y };

            removeInterval(longest);
            addInterval(left);
            addInterval(right);
            return seat;
        }

        public void Leave(int p)
        {
            int[] right = startMap[p];
            int[] left = endMap[p];

            int[] merged = new int[] { left[0], right[1] };
            removeInterval(left);
            removeInterval(right);
            addInterval(merged);
        }
    }


}