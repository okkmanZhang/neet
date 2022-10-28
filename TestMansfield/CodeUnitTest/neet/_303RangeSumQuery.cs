namespace ClassLibrary1
{
    public class NumArray
    {
        int[] preSum;
        public NumArray(int[] nums)
        {
            preSum = new int[nums.Length + 1];

            for (int i = 1; i <= nums.Length; i++)
            {
                preSum[i] = preSum[i - 1] + nums[i - 1];
            }
        }

        public int SumRange(int left, int right)
        {
            return preSum[right + 1] - preSum[left];
        }
    }
}