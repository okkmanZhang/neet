public class _268MissingNumber {
    public int MissingNumber(int[] nums) {
        int len = nums.Length;
        HashSet<int> xx = new HashSet<int>();
        for (int i = 0; i < len; i++)
        {
            xx.Add(nums[i]);
        }

        for (int i = 0; i <= len; i++)
        {
            if(!xx.Contains(i)) return i;
        }

        return 0;
    }
}