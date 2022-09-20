using LeetCodeTony;
public class _0234PalindromeLinkedList {
   public bool IsPalindrome(ListNode head) {

        if (head == null) return false;
        if (head.next == null) return true;        
        Stack<int> nodeStack = new Stack<int>();
        Stack<int> nodeStack2 = new Stack<int>();

        while (head.next != null)
        {
            nodeStack.Push(head.val);
            head = head.next;
        }

        nodeStack.Push(head.val);
        int nodeCount = nodeStack.Count();
        int x = 1;
        while(x <= nodeCount)
        {
            if ( x <= nodeCount/2)
            {
                nodeStack2.Push(nodeStack.Pop());
            } else {
                if (nodeCount%2 >0 && x ==  (nodeCount/2) +1 ) 
                {
                    nodeStack.Pop();
                    x++;
                    continue;
                }


                if (nodeStack2.Pop() != nodeStack.Pop()) return false;
            }
            x++;
        }
        return true;   
    }
}