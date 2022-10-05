namespace ClassLibrary1
{
    public class _654MaximumBinaryTree
    {


        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {

            if (nums.Length == 0) return null;

            int maxIndex = MaxIndex(nums);
            TreeNode root = new TreeNode { val = nums[maxIndex] };
            var left = nums.Take(maxIndex).ToArray();
            var right = nums.Skip(maxIndex + 1).ToArray();

            root.left = ConstructMaximumBinaryTree(left);
            root.right = ConstructMaximumBinaryTree(right);

            return root;

        }

        private int MaxIndex(int[] nums)
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    index = i;
                    max = nums[i];
                }
            }
            return index;
        }


    }
}