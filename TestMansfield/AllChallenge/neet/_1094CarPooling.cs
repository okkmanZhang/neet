namespace ClassLibrary1
{
    public class _1094CarPooling
    {
        public bool CarPooling(int[][] trips, int capacity)
        {
            int[] res = new int[1001];
            Difference diff = new Difference(res);
            for (int i = 0; i < trips.Length; i++)
            {
                int v = trips[i][0];
                int l = trips[i][1];
                int r = trips[i][2] - 1;
                diff.Increment(l, r, v);
            }

            var newRes = diff.Result();

            bool c = true;

            for (int i = 0; i < newRes.Length; i++)
            {
                if (newRes[i] > capacity)
                {
                    c = false;
                    break;
                }
            }

            return c;
        }

    }
}