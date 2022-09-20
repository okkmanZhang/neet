public class _0136SingleNumber {
    public int SingleNumber(int[] nums) {

        if (nums.Length == 1) return nums[0];
        int sum = 0;        
        for (int i = 0; i < nums.Length; i++)
        {
              sum ^= nums[i];
        }

        return sum;
    }
}