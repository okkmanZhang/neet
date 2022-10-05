public class _88MergeSortedArray {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        int n1 =0 , n2 =0;
        Queue<int> q = new Queue<int>();
        while (n1 < m || n2 < n) {

            if (n1 >= m){
                q.Enqueue(nums2[n2]);
                n2++;
                continue;
            }

            if (n2 >= n){
                q.Enqueue(nums1[n1]);
                n1++;
                continue;
            }

            if (nums1[n1] < nums2[n2]) {
                q.Enqueue(nums1[n1]);
                n1++;
                continue;
            }

            if (nums2[n2] < nums1[n1]){
                q.Enqueue(nums2[n2]);
                n2++;
                continue;
            }

            if (nums1[n1] == nums2[n2]){
                q.Enqueue(nums2[n2]);
                q.Enqueue(nums1[n1]);
                n1++;
                n2++;
                continue;
            }
        }

        for (int i = 0; i < n+m; i++)
        {
            nums1[i] = q.Dequeue();
        }
    }
}