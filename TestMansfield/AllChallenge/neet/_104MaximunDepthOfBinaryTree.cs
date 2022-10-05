public class _104MaximunDepthOfBinaryTree {
    public int MaxDepth(TreeNode root) {
        int l = 1;        

        if (root == null) return 0;

        if (root.left == null && root.right == null)
            return l;
        
        if (root.left != null && root.right == null) {            
            return 1 + MaxDepth(root.left);
        }

        if (root.left == null && root.right != null){
            
            return 1 + MaxDepth(root.right);
        }

        if (root.left != null && root.right != null){
            
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        return l;        
    }

    public int MaxDepthBacktrack(TreeNode root) {

        int res = 0;
        int dep = 0;

        Backtrack(root);
        return dep;

        void Backtrack(TreeNode node)
        {
            if(node == null) return;

            res++;
            Backtrack(node.left);
            Backtrack(node.right);
            dep = Math.Max(dep,res);
            res--;
        }        

    }    

}