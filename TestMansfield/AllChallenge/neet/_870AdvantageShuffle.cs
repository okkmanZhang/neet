using System.Collections.Generic;


namespace ClassLibrary1
{
    public class _870AdvantageShuffle
    {
        public int[] AdvantageCount(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            PriorityQueue<int[], int> maxpq = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b - a));

            for (int i = 0; i < n; i++)
            {
                maxpq.Enqueue(new int[]{i,nums2[i]},nums2[i]);
            }
            Array.Sort(nums1);

            int left = 0, right=n-1;
            int[] res = new int[n];
            while(maxpq.Count>0)
            {
                int[] pair = maxpq.Dequeue();
                int i = pair[0], maxval = pair[1];
                if(maxval<nums1[right])
                {
                    res[i]=nums1[right];
                    right--;
                }else{
                    res[i]=nums1[left];
                    left++;
                }
            }

            return res;
        }
    }
}