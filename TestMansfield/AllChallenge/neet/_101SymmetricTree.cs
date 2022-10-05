public class _101SymmetricTree {
    public bool IsSymmetric(TreeNode root) {


        if (root == null)
            return true;

        return IsSym(root.left, root.right);
    }

    public bool IsSym(TreeNode l, TreeNode r){
        if (l == null && r == null) return true;
        if (l == null || r == null) return false;

        Console.WriteLine($"{l.val}:{r.val}");
        return l.val == r.val && IsSym(l.left, r.right ) && IsSym(l.right, r.left);
        
    }
}