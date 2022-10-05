namespace ClassLibrary2
{
    public class _543DiameterOfBinaryTree
    {


        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            int maxDia = 0;
            Backtrack(root);
            return maxDia;
            
            void Backtrack(TreeNode node)
            {
                if (node==null)return;

                maxDia = Math.Max(MaxDepth(node.left)+MaxDepth(node.right), maxDia);
                Backtrack(node.left);
                Backtrack(node.right);
            }



            int MaxDepth(TreeNode node)
            {

                int dep = 0;
                int cur = 0;
                Backtrack(node);
                void Backtrack(TreeNode node)
                {
                    if (node == null) return;

                    cur++;
                    Backtrack(node.left);
                    Backtrack(node.right);
                    dep = Math.Max(dep, cur);
                    cur--;

                }
                return dep;
            }

        }


    }
}