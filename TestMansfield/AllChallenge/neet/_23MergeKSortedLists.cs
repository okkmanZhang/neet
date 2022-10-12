namespace ClassLibrary1
{
    public class _23MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {

            if (lists.Length == 0) return null;

            ListNode dummy = new ListNode { val = -1 };
            ListNode p = dummy;
            PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();

            foreach (var item in lists)
            {
                if (item != null)
                {
                    pq.Enqueue(item, item.val);
                }
            }

            while (pq.Count > 0)
            {
                var current = pq.Dequeue();
                p.next = current;

                if (current.next != null)
                {
                    pq.Enqueue(current.next, current.next.val);
                }

                p = p.next;
            }

            return dummy.next;
        }
    }
}