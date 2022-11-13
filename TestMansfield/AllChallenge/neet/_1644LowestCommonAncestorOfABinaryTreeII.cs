namespace ClassLibrary1
{
    public class _1644LowestCommonAncestorOfABinaryTreeII
    {
        bool foundP = false, foundQ = false;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var res = Find(root, p.val, q.val);
            if (!foundP || !foundQ) return null;

            return res;
        }
        private TreeNode Find(TreeNode root, int v1, int v2)
        {
            if (root == null) return null;


            var left = Find(root.left, v1, v2);
            var right = Find(root.right, v1, v2);

            if (left != null && right != null) return root;

            if (root.val == v1 || root.val == v2)
            {
                if (root.val == v1) foundP = true;
                if (root.val == v2) foundQ = true;
                return root;
            }

            return left != null ? left : right;
        }
    }
}