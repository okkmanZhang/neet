namespace ClassLibrary2
{
    public class _226InvertBinaryTree
    {


        public TreeNode InvertTree(TreeNode root)
        {

            if (root == null) return null;

            if (root.left != null || root.right != null)
            {
                TreeNode temp = root.left;
                root.left = root.right;
                root.right = temp;

                InvertTree(root.left);
                InvertTree(root.right);
            }

            return root;
        }


    }
}