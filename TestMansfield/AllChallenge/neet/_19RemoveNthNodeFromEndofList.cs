using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
             this.val = val;
             this.next = next;
         }
     }
     
    public class _19RemoveNthNodeFromEndofList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var valArray = this.GetValues(head);

            ListNode newHead = new ListNode(0,null);

            ListNode c = null;

            for (int i = 0; i < valArray.Length; i++)
            {
                if (c == null) { c = newHead; }
                
                if(i == valArray.Length-n)
                { continue; }

                ListNode v = new ListNode(valArray[i], null);
                c.next = v;

                c = v;
            }

            return newHead.next;

        }

        public int[] GetValues(ListNode head)
        {
            if(head == null) { return null; }
            if(head.next == null) { return new int[] {head.val}; }
            IList<int> vs = new List<int>();

            while(1==1)
            {
                vs.Add(head.val);
                if(head.next == null) { break; }
                head = head.next;
            }

            return vs.ToArray();
        }
    }
}
