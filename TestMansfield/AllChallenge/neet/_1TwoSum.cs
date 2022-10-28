namespace ClassLibrary1
{
    public class _1TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }

            }

            return res;
        }

        public int[] TwoSumMap(int[] nums, int target)
        {
            int[] res = new int[2];
            
            Dictionary<int,int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] =i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                //if(nums[i] > target ) continue;
                int complement = target - nums[i];

                if(map.ContainsKey(complement) && map[complement] != i)
                {
                    res[0]=i;
                    res[1]=map[complement];
                }
                
            }

            return res;

        }
    }
}