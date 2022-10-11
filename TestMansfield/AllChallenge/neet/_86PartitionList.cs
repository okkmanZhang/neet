namespace ClassLibrary1
{
    public class _86PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode dummy1 = new ListNode{val=-1};
            ListNode dummy2 = new ListNode{val=-1};
            ListNode p1 = dummy1, p2 = dummy2;
            ListNode current = head;

            while(current!=null)
            {
                if (current.val >=x)
                {
                    p2.next = current;
                    p2 = p2.next;
                }else
                {
                    p1.next=current;
                    p1 =p1.next;
                }

                ListNode temp = current.next;
                current.next = null;
                current = temp;
            }

            p1.next = dummy2.next;

            return dummy1.next;
        }
    }
}