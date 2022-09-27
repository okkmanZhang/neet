namespace ClassLibrary1
{

    public class _698PartitionKEqualSumSubsets
    {

        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            if (k > nums.Length) return false;
            if (nums.Sum() % k != 0) return false;

            int[] bucket = new int[k];
            int target = nums.Sum() / k;

            bool[] used = new bool[nums.Length];
            return Backtrack(k, 0, nums,0,used, target);

        }

        public bool Backtrack(int k, int bucket, int[] nums, int start, bool[] used, int target)
        {
            if (k==0) return true;

            if(bucket == target)
            {
                return Backtrack(k-1,0,nums,0,used,target);
            }

            for(int i=start;i<nums.Length;i++)
            {
                if(used[i]) continue;
                if(nums[i]+bucket >target) continue;

                used[i] =true;
                bucket+= nums[i];
                if (Backtrack(k,bucket,nums,i+1,used,target)) return true;
                used[i]=false;
                bucket-=nums[i];
            }

            return false;
        }




        public bool CanPartitionKSubsets1(int[] nums, int k)
        {

            if (k > nums.Length) return false;

            if (nums.Sum() % k != 0) return false;

            int[] bucket = new int[k];
            int target = nums.Sum() / k;

            Array.Sort(nums, new Comparison<int>( (i1,i2) => i2.CompareTo(i1) ));

            return Backtrack1(nums, 0, bucket, target);
        }

        private bool Backtrack1(int[] nums, int index, int[] bucket, int target)
        {
            if (index == nums.Length && !bucket.Any(b => b != target))
            {            

                return true;
            }

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] + nums[index] > target)
                { continue; }

                bucket[i] += nums[index];
                if ( Backtrack1(nums, index + 1, bucket, target))
                {
                    return true;
                }
                bucket[i] -= nums[index];
            }

            return false;
        }

    }
}