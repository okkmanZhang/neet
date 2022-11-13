namespace ClassLibrary1
{
    public class _236LowestCommonAncestorOfABinaryTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            int v1 = Math.Min(p.val,q.val);
            int v2 = Math.Max(p.val,q.val);
            return Find(root, v1,v2);
        }

        private TreeNode Find(TreeNode root, int v1, int v2)
        {
            if (root == null) return null;

            if (root.val >v2)
            {
                return Find(root.left,v1,v2);
            }

            if(root.val<v1)
            {
                return Find(root.right,v1,v2);
            }

            return root;
        }
    }
}