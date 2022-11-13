namespace ClassLibrary1
{
    public class _230KthSmallestElementInABST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            Traverse(root, k);
            return res;
        }

        int res = 0;
        int resIndex = 0;
        private void Traverse(TreeNode root, int k)
        {
            if (root == null) return;

            Traverse(root.left, k);
            resIndex++;
            if (resIndex == k) {
                res = root.val;
                return;
            }
            Traverse(root.right, k);
        }
    }
}