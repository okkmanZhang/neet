
using LeetCodeTony;

public class _0206ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {

        if (head == null) return null;
        if (head.next == null) return head;
        ListNode newHead = new ListNode();
        Stack<int> nodeStack = new Stack<int>();

        do
        {
            nodeStack.Push(head.val);
            head = head.next;
        } while (head.next != null);

        nodeStack.Push(head.val);

        ListNode currentNode = null;
        while (nodeStack.Any()){
            if(currentNode == null) {
                newHead.val = nodeStack.Pop();
                newHead.next = new ListNode();
                currentNode = newHead.next;
            } else {
                currentNode.val = nodeStack.Pop();
                if (nodeStack.Any()) {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
            }            
        }

        return newHead;
    }
}