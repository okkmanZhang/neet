namespace ClassLibrary1
{
    public class _528RandomPickWithWeight
    {
        int[] preSum;
        private Random rand = new Random();
        public _528RandomPickWithWeight(int[] w)
        {
            preSum = new int[w.Length + 1];
            preSum[0]=0;
            for (int i = 1; i <= w.Length; i++)
            {
                preSum[i] = preSum[i - 1] + w[i - 1];
            }
        }

        public int PickIndex()
        {
            int target = rand.Next(preSum[preSum.Length - 1]) + 1;
            return BinarySearchLeft(preSum, target)-1;
        }

        private int BinarySearchLeft(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;

            int left = 0, right = nums.Length ;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    right = mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}