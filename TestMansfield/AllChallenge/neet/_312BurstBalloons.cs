using System.Linq;

namespace ClassLibrary1
{
    public class _312BurstBalloons
    {

        int res = int.MinValue;
        public int MaxCoins(int[] nums)
        {
            Backtrack(nums, 0);
            return res;
        }

        private void Backtrack(int[] nums, int sc)
        {
            if (nums.Length == 0)
            {
                res = Math.Max(res, sc);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int p = (i == 0 ? 1 : nums[i - 1]) * nums[i] * (i == nums.Length - 1 ? 1 : nums[i + 1]);

                int temp = nums[i];

                var nums2 = nums.ToList();
                nums2.RemoveAt(i);
                nums = nums2.ToArray();
                Backtrack(nums, sc + p);
                nums2.Insert(i, temp);
                nums = nums2.ToArray();
            }
        }

        public int MaxCoins2(int[] nums)
        {
            int n = nums.Length;
            int[] points = new int[n + 2];
            points[0] = points[n + 1] = 1;

            for (int i = 1; i <= n; i++)
            {
                points[i] = nums[i - 1];
            }

            int[,] dp = new int[n + 2, n + 2];

            for (int i = n; i >= 0; i--)
            {
                for (int j = i + 1; j < n + 2; j++)
                {
                    for (int k = i + 1; k < j; k++)
                    {
                        dp[i, j] = Math.Max(dp[i, j], dp[i, k] + dp[k, j] + points[i] * points[j] * points[k]);
                    }
                }
            }

            return dp[0, n + 1];

        }

    }
}