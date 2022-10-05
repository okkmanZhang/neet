using System;

namespace LeetCodeTony
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class _2AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode sumList = new ListNode(-1, null);
            ListNode preNode = null;
            int carried = 0;
            bool l1end = false;
            bool l2end = false;

            while (l1.next != null || l2.next != null)
            {
                int sumCurrent = (l1end ? 0 : l1.val) + (l2end ? 0 : l2.val) + carried;
                int mv = sumCurrent > 9 ? sumCurrent - 10 : sumCurrent;
                //Console.WriteLine($"{l1.val} + {l2.val}");

                if (sumList.val == -1)
                {
                    sumList.val = mv;
                    preNode = sumList;
                }
                else
                {
                    ListNode newNode = new ListNode(mv, null);
                    preNode.next = newNode;
                    preNode = newNode;
                }

                carried = sumCurrent > 9 ? 1 : 0;

                if (l1.next != null)
                    l1 = l1.next;
                else
                    l1end = true;

                if (l2.next != null)
                    l2 = l2.next;
                else
                    l2end = true;
            }

            if (l1.val != -1 || l2.val != -1)
            {
                int sumCurrent = (l1end ? 0 : l1.val) + (l2end ? 0 : l2.val) + carried;
                int mv = sumCurrent > 9 ? sumCurrent - 10 : sumCurrent;
                //Console.WriteLine($"{l1.val} + {l2.val}");

                ListNode newNode = new ListNode(mv, null);
                if (preNode == null)
                {
                    sumList.val = mv;
                }
                else
                {
                    preNode.next = newNode;
                    preNode = newNode;
                }

                carried = sumCurrent > 9 ? 1 : 0;
            }

            if (carried > 0)
            {
                ListNode newNode = new ListNode(carried, null);
                if (preNode == null)
                {
                    sumList.next = newNode;
                }
                else
                {
                    preNode.next = newNode;
                    preNode = newNode;

                }

            }

            return sumList;
        }
    }
}