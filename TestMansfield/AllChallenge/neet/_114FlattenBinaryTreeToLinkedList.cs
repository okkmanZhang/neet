namespace ClassLibrary1
{
    public class _114FlattenBinaryTreeToLinkedList
    {


        public void Flatten(TreeNode root)
        {

            if (root == null) return;

            TreeNode left = root.left;
            TreeNode right = root.right;

            Flatten(root.left);
            Flatten(root.right);

            root.right = left;
            root.left = null;

            TreeNode lastRight = root;
            while(lastRight.right!=null)
            {
                lastRight = lastRight.right;
            }
            lastRight.right = right;

        }


    }
}