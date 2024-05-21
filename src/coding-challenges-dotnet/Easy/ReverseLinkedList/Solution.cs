namespace coding_challenges_dotnet.Easy.ReverseLinkedList;


/// <see cref="https://leetcode.com/problems/reverse-linked-list/"/>
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode reverse = null;
        while (head != null)
        {
            var temp = head.next;

            head.next = reverse;

            reverse = head;

            head = temp;
        }

        return reverse;
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
