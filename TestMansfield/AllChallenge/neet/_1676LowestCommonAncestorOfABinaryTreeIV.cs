namespace ClassLibrary1
{
    public class _1676LowestCommonAncestorOfABinaryTreeIV
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes)
        {
            HashSet<int> values = new HashSet<int>();
            foreach (var item in nodes)
            {
                values.Add(item.val);
            }

            return Find(root, values);
        }

        private TreeNode Find(TreeNode root, HashSet<int> values)
        {
            if (root == null) return null;

            if (values.Contains(root.val)) return root;

            var left = Find(root.left, values);
            var right = Find(root.right, values);

            if (left != null && right != null) return root;

            return left != null ? left : right;

        }
    }
}