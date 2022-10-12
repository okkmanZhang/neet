namespace ClassLibrary1
{
    public class _876MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode p1 = head, p2 = head;

            while (p2.next != null)
            {
                p1 = p1.next;
                if (p2.next.next != null)
                {
                    p2 = p2.next.next;
                }
                else
                {
                    p2 = p2.next;
                }
            }

            return p1;
        }
    }
}