
// Definition for a binary tree node.
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
}

public class _94BinaryTreeInorderTraversal {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> all = new List<int>{};

        if (root == null)
            return all;
        
        if (root.left != null)
            all.AddRange(InorderTraversal(root.left));

        all.Add(root.val);

        if (root.right != null)
            all.AddRange(InorderTraversal(root.right));
    
        return all;
    }

}