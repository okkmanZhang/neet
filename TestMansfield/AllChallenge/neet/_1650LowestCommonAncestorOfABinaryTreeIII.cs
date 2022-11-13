namespace ClassLibrary1
{



    public class _1650LowestCommonAncestorOfABinaryTreeIII
    {
        public Node LowestCommonAncestor(Node p, Node q)
        {
            Node a = p, b = q;
            while (a != b)
            {
                if (a == null) a = q;
                else a = a.parent;

                if (b == null) b = p;
                else b = b.parent;
            }
            return a;
        }
    }
}