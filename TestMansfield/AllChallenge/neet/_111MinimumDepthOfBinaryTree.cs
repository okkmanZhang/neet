using System.Collections.Generic;

namespace ClassLibrary1
{
    public class _111MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int res = 1;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int queueLen = queue.Count;

                for (int i = 0; i < queueLen; i++)
                {
                    var nodeNew = queue.Dequeue();
                    if (nodeNew.left == null && nodeNew.right == null)
                    {
                        return res;
                    }

                    if (nodeNew.left != null) queue.Enqueue(nodeNew.left);
                    if (nodeNew.right != null) queue.Enqueue(nodeNew.right);
                }

                res++;
            }

            return res;
        }
    }
}