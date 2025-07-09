/*
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.
*/

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        // I forgot about the possibility of creating two ListNodes 
        // when the first one goes to the next element 
        // and the second one goes to the next.next element. Now I know that.
        ListNode temp = head;
        int count = 1;
        while (temp != null)
        {
            temp = temp.next;
            count++;
        }

        int mid = count % 2 == 0 ? count / 2 - 1 : count / 2;
        temp = head;
        for (int i = 0; i < mid; i++)
        {
            temp = temp.next;
        }

        return temp;
    }
}