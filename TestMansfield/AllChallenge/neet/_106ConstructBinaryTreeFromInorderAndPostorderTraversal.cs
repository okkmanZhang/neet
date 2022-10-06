namespace ClassLibrary1
{
    public class _106ConstructBinaryTreeFromInorderAndPostorderTraversal
    {


        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {

            if (inorder.Length == 0) return null;
            int rootInOrderIndex = -1;
            for (int i = 0; i < inorder.Length; i++)
            {
                if (inorder[i] == postorder[postorder.Length - 1])
                {
                    rootInOrderIndex = i;
                    break;
                }
            }

            TreeNode root = new TreeNode() { val = postorder[postorder.Length - 1] };
            root.left = BuildTree(
                inorder.Take(rootInOrderIndex).ToArray(),
                postorder.Take(rootInOrderIndex).ToArray()
            );
            root.right = BuildTree(
                inorder.Skip(rootInOrderIndex + 1).ToArray(),
                postorder.Skip(rootInOrderIndex).Take(postorder.Length - rootInOrderIndex - 1).ToArray()
            );

            return root;
        }


    }
}