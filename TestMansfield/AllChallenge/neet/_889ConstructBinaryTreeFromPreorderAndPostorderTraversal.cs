namespace ClassLibrary1
{
    public class _889ConstructBinaryTreeFromPreorderAndPostorderTraversal
    {


    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {

     if(preorder.Length==0) return null;

     TreeNode root = new TreeNode(){val=preorder[0]};
     if(preorder.Length==1) return root;

     int leftRootPostorderIndex = -1;
     for(int i=0;i<postorder.Length;i++)
     {
        if(postorder[i]==preorder[1])
        {
            leftRootPostorderIndex = i;
            break;
        }
     }

     root.left=ConstructFromPrePost(
        preorder.Skip(1).Take(leftRootPostorderIndex+1).ToArray(),
        postorder.Take(leftRootPostorderIndex+1).ToArray()
     );
     root.right=ConstructFromPrePost(
        preorder.Skip(leftRootPostorderIndex+2).ToArray(),
        postorder.Skip(leftRootPostorderIndex+1).SkipLast(1).ToArray()
     );

        return root;

    }

    }
}