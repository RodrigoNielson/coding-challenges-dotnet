namespace leetcode_dotnet.Medium.RemoveNodesFromLinkedList;

/// <see cref="https://leetcode.com/problems/remove-nodes-from-linked-list/description/"/>
public class Solution
{
    public ListNode RemoveNodes(ListNode head)
    {
        ListNode reverse = null;

        while (head != null)
        {
            var next = head.next;

            head.next = reverse;

            reverse = head;

            head = next;
        }

        while (reverse != null)
        {
            var next = reverse.next;

            if (next != null && next.val < reverse.val)
            {
                reverse.next = next.next;
                continue;
            }

            reverse.next = head;

            head = reverse;

            reverse = next;
        }

        return head;
    }
}

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
