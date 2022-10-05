using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _102BinaryTreeLevelOrderTraversal
    {
        //BFS
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var len = q.Count;
                IList<int> level = new List<int>();

                for (int i = 0; i < len; i++)
                {
                    var node = q.Dequeue();
                    if (node != null)
                    {
                        level.Add(node.val);
                        if (node.left !=null) q.Enqueue(node.left);
                        if (node.right !=null) q.Enqueue(node.right);
                    }
                }
                if (level.Count > 0)
                    res.Add(level);

            }
            return res;
        }
    }
}

 