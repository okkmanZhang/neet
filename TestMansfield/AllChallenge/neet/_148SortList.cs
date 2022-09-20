using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _148SortList
    {
        //merge sort
        //https://www.youtube.com/watch?v=TGveA1oFhrc&ab_channel=NeetCode
        public ListNode SortList(ListNode head)
        {
            List<int> newList = new List<int>();

            ListNode currentNode = head;
            while(currentNode != null && currentNode.val >= -100000 && currentNode.val<=100000)
            {
                newList.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            newList.Sort((a, b) => a < b ? -1 : (a > b ? 1 : 0));

            ListNode newHead = null;
            ListNode preNode = null;

            foreach(int i in newList)
            {
                if (newHead==null)
                {
                    newHead = new ListNode(i);
                    preNode = newHead;
                } else
                {
                    ListNode n = new ListNode(i);
                    preNode.next = n;
                    preNode = n;
                }
            }

            return newHead;
        }
    }
}
