namespace ClassLibrary1
{
    public class _384ShuffleAnArray
    {
        int[] origin;
        Random rd;
        public _384ShuffleAnArray(int[] nums)
        {
            origin =nums;
            rd = new Random();
        }

        public int[] Reset()
        {
            return origin;
        }

        public int[] Shuffle()
        {
            var res = origin.ToArray();
            for (int i = 0; i < res.Length; i++)
            {
                int r = i + rd.Next(res.Length-i);
                Swap(res,i,r);
            }

            return res;
        }

        private void Swap(int[] nums, int i,int j)
        {
            int temp = nums[i];
            nums[i]=nums[j];
            nums[j]=temp;
        }
    }
}