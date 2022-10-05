public class _217ContainsDuplicate {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> x = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (x.Contains(nums[i])) return true;

            x.Add(nums[i]);            
        }

        return false;
    }
}