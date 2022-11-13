namespace ClassLibrary1
{
    public class _538ConvertBSTToGreaterTree
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            Traverse(root);
            return root;
        }

        int sum=0;
        private void Traverse(TreeNode root)
        {
            if(root==null) return;

            Traverse(root.right);
            sum += root.val;
            root.val = sum;
            Traverse(root.left);
        }

    }
}