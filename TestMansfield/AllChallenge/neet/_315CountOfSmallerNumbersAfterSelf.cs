using System.Collections.Generic;

namespace ClassLibrary1
{
    public class _315CountOfSmallerNumbersAfterSelf
    {
        public IList<int> CountSmaller(int[] nums)
        {

            int n = nums.Length;
            count = new int[n];
            temp = new Pair[n];

            Pair[] arr = new Pair[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Pair { Val = nums[i], Id = i };
            }

            MergeSort(arr, 0, n - 1);

            return new List<int>(count);

        }

        private class Pair
        {
            public int Val;
            public int Id;
        }

        private Pair[] temp;
        private int[] count;


        #region merge sort

        private void MergeSort(Pair[] arr, int lo, int hi)
        {
            if (lo == hi) return;

            int md = lo + (hi - lo) / 2;

            MergeSort(arr, lo, md);
            MergeSort(arr, md + 1, hi);

            Merge(arr, lo, md, hi);
        }

        private void Merge(Pair[] arr, int lo, int md, int hi)
        {

            for (int i2 = 0; i2 < arr.Length; i2++)
            {
                temp[i2] = arr[i2];
            }

            int i = lo;
            int j = md + 1;
            for (int p = lo; p <= hi; p++)
            {
                if (i == md + 1)
                {
                    arr[p] = temp[j++];
                }
                else if (j == hi + 1)
                {
                    arr[p] = temp[i++];
                    count[arr[p].Id] += j - md - 1;
                }
                else if (temp[i].Val > temp[j].Val)
                {
                    arr[p] = temp[j++];
                }
                else
                {
                    arr[p] = temp[i++];
                    count[arr[p].Id] += j - md - 1;
                }
            }

        }
        #endregion
    }

}