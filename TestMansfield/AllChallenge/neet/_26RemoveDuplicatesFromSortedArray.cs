namespace LeetCodeTony
{
    public class _26RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {

            int removed = 0;
            int temp = -300;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == temp)
                {
                    nums[i] = -200;
                    removed++;
                }
                else
                    temp = nums[i];
            }

            int rest = nums.Count() - removed;
            // Console.WriteLine( string.Join(",", nums));
            // Console.WriteLine(rest);

            for (int i = 0; i < nums.Count(); i++)
            {
                if (i <= rest - 1 && nums[i] == -200)
                {
                    for (int j = i + 1; j < nums.Count(); j++)
                    {
                        if (nums[j] != -200)
                        {
                            nums[i] = nums[j];
                            nums[j] = -200;

                            //Console.WriteLine( string.Join(",", nums));
                            break;

                        }

                    }
                }
            }

            // Console.WriteLine( string.Join(",", nums));
            // Console.WriteLine(rest);

            return rest;
        }

        public int RemoveDuplicatesDoublePoints(int[] nums)
        {
            if (nums.Length==1) return 1;
            
            int p1 = 0, p2 =1;

            while(p2<=nums.Length-1)
            {
                if(nums[p1]!=nums[p2])
                {
                    p1++;
                    nums[p1]=nums[p2];
                }
                p2++;
            }

            return p1+1;
        }
    }
}