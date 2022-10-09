using System.Text;

namespace ClassLibrary1
{
    public class _652FindDuplicateSubtrees
    {

        IList<TreeNode> res = new List<TreeNode>();
        Dictionary<string, int> subTrees = new Dictionary<string, int>();
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {

            if (root == null) return null;

            string left = Serialize(root.left);
            string right = Serialize(root.right);

            string all = Serialize(root);
            if (subTrees.ContainsKey(all)) { subTrees[all]++;} else {subTrees[all]=1;}
            if (subTrees[all] == 2) res.Add(root);

            FindDuplicateSubtrees(root.left);
            FindDuplicateSubtrees(root.right);

            return res;
        }


        string NULL_NODE = "#";
        string DELIMITER = ",";

        private string Serialize(TreeNode node)
        {

            if (node == null) return NULL_NODE + DELIMITER;

            StringBuilder sb = new StringBuilder();
            sb.Append(node.val).Append(DELIMITER);
            sb.Append(Serialize(node.left));
            sb.Append(Serialize(node.right));

            return sb.ToString();
        }


    }
}