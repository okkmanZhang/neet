namespace ClassLibrary1
{
    public class _496NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2) {
            int[] greater = NextGreaterElement(nums2);
            Dictionary<int,int> greaterMap = new Dictionary<int, int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                greaterMap.Add(nums2[i], greater[i]);
            }
            int[] res = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                res[i]=greaterMap[nums1[i]];
            }

            return res;
        }

        int[] NextGreaterElement(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];
            Stack<int> s = new Stack<int>();

            for (int i = n-1; i >=0; i--)
            {
                while(s.Count()>0 && s.Peek()<=nums[i])
                {
                    s.Pop();
                }

                res[i] = s.Count() ==0? -1: s.Peek();
                s.Push(nums[i]);
            }

            return res;
        }
    }
}