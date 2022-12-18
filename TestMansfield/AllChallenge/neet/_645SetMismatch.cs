namespace ClassLibrary1
{
    public class _645SetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {

            int n = nums.Length;
            int dup = -1;
            for (int i = 0; i < n; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                    dup = Math.Abs(nums[i]);
                else
                    nums[index] *= -1;
            }

            int mis = -1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                    mis = i + 1;
            }

            return new int[] { dup, mis };
        }
    }
}