namespace ClassLibrary1
{
    public class _27RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int p1 = 0, p2 = 0;
            while(p2<nums.Length)
            {
                if(nums[p2]!=val)
                {
                    nums[p1]=nums[p2];
                    p1++;
                }
                p2++;
            }

            return p1;
        }
    }
}