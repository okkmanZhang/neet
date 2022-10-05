namespace ClassLibrary2
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class _124BinaryTreeMaximumPathSum
    {
        public int MaxPathSum(TreeNode root)
        {
            int res = int.MinValue;
            Traverse(root);
            int Traverse(TreeNode node)
            {
                if(node == null) return 0;
                int left = Math.Max(0,Traverse(node.left));
                int right = Math.Max(0, Traverse(node.right));

                res = Math.Max(res, left+right+node.val);
                return Math.Max(left,right) + node.val;                
            }


            return res;
        }


    }
}