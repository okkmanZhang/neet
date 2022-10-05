public class _169MajorityElement {
    public int MajorityElement(int[] nums) {

        if (nums.Length == 1) return nums[0];

        int maj = int.MaxValue;
        int majTimes = 0;

        for (int i = 0; i < nums.Length; i++){
        
            
            int currentTimes = 0;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]){
                    currentTimes++;
                }                
            }

            if (currentTimes > majTimes) {
                maj = nums[i];
                majTimes = currentTimes;
            }            
        }

        return maj;
    }
}