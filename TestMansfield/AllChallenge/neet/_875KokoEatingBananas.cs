namespace ClassLibrary1
{
    public class _875KokoEatingBananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = 1000000000 + 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (f(piles, mid) == h)
                {
                    right = mid;
                }
                else if (f(piles, mid) < h)
                {
                    right = mid;
                }
                else if (f(piles, mid) > h)
                {
                    left = mid + 1;
                }
            }

            return left;

        }

        private int f(int[] piles, int x)
        {
            int hours = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                hours += piles[i] / x;
                if (piles[i] % x > 0)
                {
                    hours++;
                }
            }

            return hours;
        }
    }
}