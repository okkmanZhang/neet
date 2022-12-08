public class _53MaximunSubarray
{

    public int MaxSubArray(int[] nums)
    {

        int temp = -100000;
        int sum = 0;

        if (nums.Length == 1)
            return nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum > temp)
                temp = sum;

            if (sum < 0)
                sum = 0;
        }


        //Console.WriteLine(temp);
        return temp;
    }

    public int MaxSubArraySlideWindow(int[] nums)
    {
        int l = 0, r = 0;
        int maxSum = int.MinValue;
        int sum = 0;

        while (r < nums.Length)
        {
            sum += nums[r];
            r++;

            maxSum = Math.Max(maxSum, sum);

            while (sum < 0)
            {
                sum -= nums[l];
                l++;
            }
        }

        return maxSum;
    }

    public int MaxSubArrayDP(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return 0;
        int[] dp = new int[n];

        dp[0] = nums[0];
        for (int i = 1; i < n; i++)
        {
            dp[i] = Math.Max(nums[i], dp[i - 1] + nums[i]);
        }
        int res = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            res = Math.Max(res, dp[i]);
        }
        return res;
    }
}