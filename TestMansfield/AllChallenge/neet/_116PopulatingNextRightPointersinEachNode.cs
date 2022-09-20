using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class _116PopulatingNextRightPointersinEachNode
    {
        public Node Connect(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var len = q.Count;

                Node preNode = null;
                for (int i = 0; i < len; i++)
                {
                    var node = q.Dequeue();

                    if (preNode != null)
                    {
                        preNode.next = node;                        
                    }

                    //Console.Write(node.val);
                    if (node != null)
                    {
                        if (node.left != null) q.Enqueue(node.left);
                        if (node.right != null) q.Enqueue(node.right);
                    }

                    preNode = node;
                }

                if (preNode!=null)
                {
                    preNode.next = null;
                }

                //Console.WriteLine();
         
            }
            return root;

        }
    }
}
