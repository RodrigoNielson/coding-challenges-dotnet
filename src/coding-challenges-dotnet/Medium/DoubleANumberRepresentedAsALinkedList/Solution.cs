namespace coding_challenges_dotnet.Medium.DoubleANumberRepresentedAsALinkedList;
/// <see cref="https://leetcode.com/problems/double-a-number-represented-as-a-linked-list/description/"/>
public class Solution
{
    public ListNode DoubleIt(ListNode head)
    {
        ListNode reversed = null;

        var number = 0;

        while (head != null)
        {
            var temp = head;

            number *= 10;
            number += head.val;
            head = head.next;

            temp.next = reversed;
            reversed = temp;
        }

        int overflow = 0;
        while (reversed != null)
        {
            var tempValue = reversed.val * 2 + overflow;

            if (tempValue >= 10)
            {
                overflow = 1;
                tempValue -= 10;
            }
            else
            {
                overflow = 0;
            }

            reversed.val = tempValue;

            var temp = reversed;
            reversed = reversed.next;
            temp.next = head;
            head = temp;
        }

        if (reversed == null && overflow == 1)
        {
            reversed = new ListNode(1, head);

            head = reversed;
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
