using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1._138
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class _138CopyListwithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            Dictionary<int, Node> oldList = new Dictionary<int, Node>();
            Dictionary<Node,int> randoms = new Dictionary<Node,int>();
            Dictionary<int, Node> newList = new Dictionary<int, Node>();
            Dictionary<int, int> newRandoms = new Dictionary<int, int>();

            Node currentNode = head;
            int i = 0;
            while(currentNode != null && currentNode.val>=-10000 && currentNode.val <= 10000)
            {
                oldList.Add(i, currentNode);
                randoms.Add(currentNode, i);

                currentNode = currentNode.next;
                i++;
            }

            currentNode = head;
            i = 0;
            while (currentNode != null && currentNode.val >= -10000 && currentNode.val <= 10000)
            {
                if (currentNode.random != null)
                {
                    newRandoms.Add(i, randoms[currentNode.random]);
                }
                
                currentNode = currentNode.next;
                i++;
            }


            Node newHead = null;
            currentNode = head;
            i = 0;
            Node preNode = null;
            while (currentNode != null && currentNode.val >= -10000 && currentNode.val <= 10000)
            {
                Node oldNode = oldList[i];
                Node newNode = new Node(oldNode.val);
                if (preNode == null)
                {
                    preNode = newNode;
                    newHead = preNode;
                }
                else
                {
                    preNode.next = newNode;
                    preNode = newNode;
                }

                newList.Add(i, newNode);

                currentNode = currentNode.next;
                i++;
            }

            currentNode = newHead;
            i = 0;
            while (currentNode != null && currentNode.val >= -10000 && currentNode.val <= 10000)
            {
                if (newRandoms.ContainsKey(i))
                {
                    currentNode.random = newList[newRandoms[i]];
                }

                currentNode = currentNode.next;
                i++;
            }

            return newHead;

        }
    }
}
