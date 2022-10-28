namespace ClassLibrary1
{
    public class _370RangeAddition
    {
        public int[] GetModifiedArray(int length, int[][] updates)
        {
            int[] res = new int[length];

            Difference diff = new Difference(res);
            for (int i = 0; i < updates.Length; i++)
            {
                int l = updates[i][0];
                int r = updates[i][1];
                int v = updates[i][2];

                diff.Increment(l, r, v);
            }

            return diff.Result();
        }

    }

    class Difference
    {
        private int[] diff;
        public Difference(int[] nums)
        {
            if (nums.Length == 0) return;

            diff = new int[nums.Length];

            diff[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                diff[i] = nums[i] - nums[i - 1];
            }
        }

        public void Increment(int i, int j, int val)
        {
            diff[i] += val;
            if (j + 1 < diff.Length)
                diff[j + 1] -= val;
        }

        public int[] Result()
        {
            int[] res = new int[diff.Length];
            res[0] = diff[0];
            for (int i = 1; i < diff.Length; i++)
            {
                res[i] = res[i - 1] + diff[i];
            }

            return res;
        }

    }
}