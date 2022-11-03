namespace ClassLibrary1
{
    public class _1011CapacityToShipPackagesWithinDdays
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            int left = 0;
            int right = 1;

            for (int i = 0; i < weights.Length; i++)
            {
                left = Math.Max(left, weights[i]);
                right += weights[i];
            }

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (f(weights, mid) == days)
                {
                    right = mid;
                }
                else if (f(weights, mid) < days)
                {
                    right = mid;
                }
                else if (f(weights, mid) > days)
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private int f(int[] w, int c)
        {
            int days = 0;
            for (int i = 0; i < w.Length;)
            {
                int cap = c;

                while (i < w.Length)
                {
                    if (cap < w[i]) break;
                    else
                        cap -= w[i];

                    i++;
                }
                days++;
            }

            return days;
        }
    }
}