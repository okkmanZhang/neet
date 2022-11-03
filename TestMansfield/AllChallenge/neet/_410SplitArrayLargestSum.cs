namespace ClassLibrary1
{
    public class _410SplitArrayLargestSum
    {
        public int SplitArray(int[] nums, int k)
        {
            int left = 0;
            int right = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                left = Math.Max(left, nums[i]);
                right += nums[i];
            }

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (f(nums, mid) == k)
                {
                    right = mid;
                }
                else if (f(nums, mid) < k)
                {
                    right = mid;
                }
                else if (f(nums, mid) > k)
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

