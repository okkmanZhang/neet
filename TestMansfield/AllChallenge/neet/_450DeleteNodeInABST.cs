namespace ClassLibrary1
{
    public class _450DeleteNodeInABST
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;
            if (root.val == key)
            {
                if (root.left == null) return root.right;
                if (root.right == null) return root.left;

                var min = GetMin(root.right);
                root.right = DeleteNode(root.right, min.val);
                min.left = root.left;
                min.right = root.right;
                root = min;
            }
            else if (root.val > key)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if (root.val < key)
            {
                root.right = DeleteNode(root.right, key);
            }

            return root;
        }

        private TreeNode GetMin(TreeNode root)
        {
            while (root.left != null) root = root.left;

            return root;
        }
    }
}