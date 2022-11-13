namespace ClassLibrary1
{
    public class _95UniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if(n ==0) return new List<TreeNode>();

            return Build(1,n);
        }

        IList<TreeNode> Build( int lo, int hi){
            List<TreeNode> res = new List<TreeNode>();
            if(lo>hi){
                res.Add(null);
                return res;
            }

            for (int mid = lo; mid <= hi; mid++)
            {
                IList<TreeNode> left = Build(lo,mid-1);
                IList<TreeNode> right = Build(mid+1,hi);

                foreach (var itemL in left)
                {
                    foreach (var itemR in right)
                    {
                        TreeNode root = new TreeNode(mid);
                        root.left = itemL;
                        root.right = itemR;
                        res.Add(root);
                    }                    
                }
            }

            return res;
        }
    }
}