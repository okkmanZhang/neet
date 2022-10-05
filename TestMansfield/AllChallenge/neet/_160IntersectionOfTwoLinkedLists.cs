/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
namespace _160IntersectionOfTwoLinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class _0160IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode ha = headA;
            ListNode hb = headB;

            if (ha == hb) return ha;

            if (ha.next == null && hb.next != null)
            {
                do
                {
                    if (ha == hb) return ha;
                    hb = hb.next;
                } while (hb != null);

                return null;
            }

            if (hb.next == null && ha.next != null)
            {
                do
                {
                    if (ha == hb) return ha;
                    ha = ha.next;
                } while (ha != null);

                return null;
            }

            while (ha != null)
            {
                while (hb != null)
                {
                    if (ha == hb) return ha;
                    hb = hb.next;
                }
                ha = ha.next;
                hb = headB;
            }

            return null;
        }
    }
}