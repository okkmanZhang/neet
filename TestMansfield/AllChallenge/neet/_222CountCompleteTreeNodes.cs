namespace ClassLibrary1
{
    public class _222CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }


    }
}