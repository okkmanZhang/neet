namespace ClassLibrary1
{
    public class _382LinkedListRandomNode
    {
        ListNode _head;
        public _382LinkedListRandomNode(ListNode head)
        {
            _head = head;
        }

        public int GetRandom()
        {
            Random r = new Random();
            int i=0; 
            int res=0;
            ListNode p = _head;

            while(p!=null)
            {
                i++;
                if(0==r.Next(i))
                {
                    res=p.val;
                }
                p=p.next;
            }

            return res;
        }

    }
}