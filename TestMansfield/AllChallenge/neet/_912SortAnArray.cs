using System;

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

        #region quick sort
        public int[] QuickSort(int[] nums)
        {
            Shuffle(nums);
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void QuickSort(int[] nums, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }

            int p = Partition(nums, lo, hi);

            QuickSort(nums, lo, p - 1);
            QuickSort(nums, p + 1, hi);
        }

        private int Partition(int[] nums, int lo, int hi)
        {
            int pivot = nums[lo];
            int i = lo + 1, j = hi;
            while (i <= j)
            {
                while (i < hi && nums[i] <= pivot)
                {
                    i++;
                }
                while (j > lo && nums[j] > pivot)
                {
                    j--;
                }
                if (i >= j)
                {
                    break;
                }

                Swap(nums, i, j);

            }
            Swap(nums, lo, j);
            return j;
        }

        private void Shuffle(int[] nums)
        {
            Random rand = new Random();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + rand.Next(n - i);
                Swap(nums, i, r);
            }
        }
        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        #endregion
    }
}