public class _0350IntersectionOfTwoArrays2 {
    public int[] Intersect(int[] nums1, int[] nums2) {


        List<int> x = new List<int>();
        
        bool start = false;
        int startIndex = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    x.Add(nums1[i]);
                    nums2[j] = -1;
                    // start = true;
                    // startIndex = j+1;
                    // Console.WriteLine(startIndex);
                    break;
                    
                }

                // if (nums1[i] != nums2[j] && start == true) {
                //     return x.ToArray();
                // }
                
            }
        }

        return x.ToArray();
    }
}