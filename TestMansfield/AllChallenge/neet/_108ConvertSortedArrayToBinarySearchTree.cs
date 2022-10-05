using System.Linq;

public class _108ConvertSortedArrayToBinarySearchTree {
    public TreeNode SortedArrayToBST(int[] nums) {
        
        if (nums.Length == 0) return null;
        if (nums.Length == 1) return new TreeNode(nums[0], null, null);

        int mid = nums.Length/2;

        TreeNode root = new TreeNode(nums[mid], 
            AddArray(nums, 0, mid -1),
            AddArray(nums, mid +1, nums.Length -1) );        

        return root;
    }

    public TreeNode AddArray(int[] nums, int l, int r)
    {
        if (l > r) return null;
            
        int mid = (r + l)/2;
        TreeNode root = new TreeNode(nums[mid], 
            AddArray(nums, l, mid-1),
            AddArray(nums, mid+1, r));

        return root;
    }

    public List<int?> ToList(TreeNode r) {
        return new List<int?>{};
    }
}