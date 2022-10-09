using System.Text;

namespace ClassLibrary1
{
    public class _297SerializeAndDeserializeBinaryTree
    {


        string NULL_NODE = "#";
        string DELIMITER = ",";

        #region preorder
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return NULL_NODE + DELIMITER;

            StringBuilder sb = new StringBuilder();
            sb.Append(root.val.ToString()).Append(DELIMITER);
            sb.Append(serialize(root.left)).Append(serialize(root.right));

            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {

            if (data.Last().ToString() == DELIMITER)
            {
                data = string.Join("", data.SkipLast(1));
            }

            List<string> nodes = data.Split(DELIMITER).ToList<string>();
            return Help(nodes);

        }

        public TreeNode Help(List<string> nodes)
        {

            if (nodes.Count == 0) return null;
            var rootValue = nodes[0];
            nodes.RemoveAt(0);

            if (rootValue == NULL_NODE)
            {
                return null;
            }

            TreeNode root = new TreeNode { val = Int32.Parse(rootValue) };
            root.left = Help(nodes);
            root.right = Help(nodes);

            return root;

        }
        #endregion

        #region postorder
        public string serializePost(TreeNode root)
        {
            if (root==null) return NULL_NODE + DELIMITER;

            StringBuilder sb = new StringBuilder();
            sb.Append(serializePost(root.left));
            sb.Append(serializePost(root.right));
            sb.Append(root.val.ToString()).Append(DELIMITER);

            return sb.ToString();
        }
        public TreeNode deserializePost(string data)
        {
            if(data.Length==0) return null;

            List<string> nodes = new List<string>();
            nodes = data.Split(',').SkipLast(1).ToList<string>();

            return helpPost(nodes);
        }

        public TreeNode helpPost(List<string> nodes)
        {
            if (nodes.Count==0) return null;

            var lastNode = nodes[nodes.Count-1];
            nodes.RemoveAt(nodes.Count-1);

            if (lastNode == NULL_NODE)
            {
                return null;
            }

            TreeNode root = new TreeNode{val=Convert.ToInt32(lastNode)};
            root.right = helpPost(nodes);
            root.left = helpPost(nodes);

            return root;
        }
        #endregion
    }
}