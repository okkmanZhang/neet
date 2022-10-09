namespace ClassLibrary1
{
    public class _912SortAnArray
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length == 0) return nums;
            temp = new int[nums.Length];
            MergeSort(nums, 0, nums.Length - 1);
            return nums;

        }

        #region merge sort
        int[] temp;
        private void MergeSort(int[] nums, int lo, int hi)
        {
            if (lo == hi) return;

            int md = lo + (hi - lo) / 2;

            MergeSort(nums, lo, md);
            MergeSort(nums, md + 1, hi);

            Merge(nums, lo, md, hi);
        }

        private void Merge(int[] nums, int lo, int md, int hi)
        {

            for (int i2 = 0; i2 < nums.Length; i2++)
            {
                temp[i2] = nums[i2];
            }

            int i = lo;
            int j = md + 1;
            for (int p = lo; p <= hi; p++)
            {
                if (i == md + 1)
                {
                    nums[p] = temp[j++];
                }
                else if (j == hi + 1)
                {
                    nums[p] = temp[i++];
                }
                else if (temp[i] > temp[j])
                {
                    nums[p] = temp[j++];
                }
                else
                {
                    nums[p] = temp[i++];
                }
            }

        }
        #endregion
    }
}