using LeetCodeTony;

public class _0237DeleteNodeInALinkedList {
    public void DeleteNode(ListNode node) {        
        Console.WriteLine(node.val);
        node.val = node.next.val;
        node.next = node.next.next;
        
        Console.WriteLine(node.val);

    }
}