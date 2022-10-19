namespace ClassLibrary1
{
    public class _704BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            if (target < nums[left] || nums[right] < target) return -1;


            while (left <= right)
            {                           

                int mid = (right - left) / 2 + left;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target )
                {
                    right = mid-1;
                }
                else if (nums[mid] < target)
                {
                    left = mid+1;
                }

                
            }

            return -1;
        }
    }
}