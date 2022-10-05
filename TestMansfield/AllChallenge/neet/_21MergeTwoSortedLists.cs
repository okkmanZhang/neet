namespace LeetCodeTony
{



    public class _21MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {       
            Queue<int> q = new Queue<int>();

            if (list1 == null && list2 == null)
                return null;

            if (list1 != null && list2 ==null)
                return list1;
            
            if (list1 == null && list2 != null)
                return list2;

            bool l1end = false;
            bool l2end = false;

            while (list1.next != null || list2.next != null)
            {
                Console.WriteLine($"l1{l1end},{list1.val} , l2{l2end},{list2.val}, q{q.Count}");

                if (l1end && !l2end) {
                    q.Enqueue(list2.val);
                    if(list2.next != null)
                        list2 = list2.next;
                    else
                        l2end = true;
                }

                if (l2end && !l1end)
                {
                    q.Enqueue(list1.val);
                    if(list1.next != null)
                        list1 = list1.next;
                    else
                        l1end = true;
                }

                if (!l1end && !l2end && list1.val <= list2.val) {
                    q.Enqueue(list1.val);
                    if (list1.next != null)
                        list1 = list1.next;
                    else
                        l1end = true;

                } else if (!l1end && !l2end && list1.val > list2.val) {
                    
                    q.Enqueue(list2.val);
                    if(list2.next != null)
                        list2 = list2.next;
                    else
                        l2end = true;
                }

            }

                Console.WriteLine($"*l1{l1end},{list1.val} , l2{l2end},{list2.val}, q{q.Count}");

            if (l1end && !l2end)                
                q.Enqueue(list2.val);

            if (!l1end && l2end)                
                 q.Enqueue(list1.val);

            if (!l1end && !l2end && list1.val <= list2.val){
                q.Enqueue(list1.val);            
                q.Enqueue(list2.val);
            }
            else if (!l1end && !l2end && list1.val > list2.val){
                q.Enqueue(list2.val);
                q.Enqueue(list1.val);
            }

            ListNode newNode = null;
            ListNode cNode = null;

            while (q.Any()) {

                //Console.WriteLine(q.Dequeue());

                if (newNode == null){
                     newNode = new ListNode(q.Dequeue(), null);
                     cNode = newNode;
                }
                else {
                     cNode.next = new ListNode(q.Dequeue(), null);
                     cNode = cNode.next;
                 }
            }

            return newNode;
        }
    }
}