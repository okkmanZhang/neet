namespace ClassLibrary1
{
    public class _92ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null) return null;

            ListNode cur = head, prev = null;
            while (left > 1)
            {
                prev = cur;
                cur = cur.next;
                left--;
                right--;
            }

            ListNode con = prev, tail = cur;

            ListNode third = null;
            while (right > 0)
            {
                third = cur.next;
                cur.next = prev;
                prev = cur;
                cur = third;
                right--;
            }

            if (con != null)
            {
                con.next = prev;
            }
            else
            {
                head = prev;
            }
            tail.next = cur;
            return head;
        }
    }
}