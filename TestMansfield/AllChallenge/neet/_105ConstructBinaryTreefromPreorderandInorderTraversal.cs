using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _105ConstructBinaryTreefromPreorderandInorderTraversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            TreeNode helper(int preStart, int inStart, int inEnd)
            {
                if (preStart > preorder.Length - 1 || inStart > inEnd) return null;

                TreeNode root = new TreeNode(preorder[preStart]);

                int inIndex = 0;
                for(int i=0; i<=inEnd; i++)
                {
                    if(root.val == inorder[i])
                    {
                        inIndex = i;
                        break;
                    }
                }

                root.left = helper(preStart + 1, inStart, inIndex - 1);
                root.right = helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd);
                return root;
            }

            return helper(0, 0, inorder.Length - 1);
        }
    }
}
