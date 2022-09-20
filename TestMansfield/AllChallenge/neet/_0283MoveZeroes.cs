public class _0283MoveZeroes {
    public void MoveZeroes(int[] nums) {
        
        if (nums.Length <= 1) return;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] != 0 && nums[i] == 0){                        
                        nums[i] = nums[j];
                        nums[j] = 0;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(",", nums));

    }
}