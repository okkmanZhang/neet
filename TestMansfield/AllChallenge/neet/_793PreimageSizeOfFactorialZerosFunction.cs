namespace ClassLibrary1
{
    public class _793PreimageSizeOfFactorialZerosFunction
    {
        public int PreimageSizeFZF(int k)
        {
            return (int)(Right_bound(k) - Left_bound(k) + 1);
        }

        long Left_bound(int target)
        {
            long lo = 0, hi = long.MaxValue;
            while (lo < hi)
            {
                long mid = lo + (hi - lo) / 2;
                if (TrailingZeroes(mid) < target)
                {
                    lo = mid + 1;
                }
                else if (TrailingZeroes(mid) > target)
                {
                    hi = mid;
                }
                else
                {
                    hi = mid;
                }
            }
            return lo;
        }

        long Right_bound(int target)
        {
            long lo = 0, hi = long.MaxValue;
            while (lo < hi)
            {
                long mid = lo + (hi - lo) / 2;
                if (TrailingZeroes(mid) < target)
                {
                    lo = mid + 1;
                }
                else if (TrailingZeroes(mid) > target)
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            return lo - 1;
        }

        public long TrailingZeroes(long n)
        {
            long res = 0;
            for (long i = n; i > 1; i = i / 5)
            {
                res += i / 5;
            }
            return res;
        }
    }
}