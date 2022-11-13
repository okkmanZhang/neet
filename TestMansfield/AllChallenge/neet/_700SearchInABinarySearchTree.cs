namespace ClassLibrary1
{
    public class _700SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            Traverse(root, val);

            return res;
        }

        TreeNode res;
        private void Traverse(TreeNode root, int val)
        {
            if (root == null) return;

            if (root.val == val)
            {
                res = root;
                return;
            }

            Traverse(root.left, val);
            Traverse(root.right, val);
        }

        public TreeNode SearchBST2(TreeNode root, int val)
        {
            if (root == null) return null;

            if (val > root.val)
            {
                return SearchBST2(root.right, val);
            }

            if (val < root.val)
            {
                return SearchBST2(root.left, val);
            }

            return root;
        }
    }
}