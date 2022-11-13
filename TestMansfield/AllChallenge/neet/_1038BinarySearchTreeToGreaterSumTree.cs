namespace ClassLibrary1
{
    public class _1038BinarySearchTreeToGreaterSumTree
    {
        public TreeNode BstToGst(TreeNode root)
        {
            Traverse(root);
            return root;
        }

        int sum = 0;
        private void Traverse(TreeNode root)
        {

            if (root == null) return;

            Traverse(root.right);
            sum += root.val;
            root.val = sum;
            Traverse(root.left);
        }
    }
}