public class _0104MaximunDepthOfBinaryTree {
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
}