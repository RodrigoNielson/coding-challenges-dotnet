using FluentAssertions;
using leetcode_dotnet.Easy.ReverseLinkedList;
using Xunit;

namespace leetcode_dotnet_test.Easy;
public class ReverseLinkedListTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            CreateLinkedList([1, 2, 3, 4, 5]),
            CreateLinkedList([5, 4, 3, 2, 1])
        };

        // Example 2:
        yield return new object[]
        {
            CreateLinkedList([1, 2]),
            CreateLinkedList([2, 1])
        };

        // Example 2:
        yield return new object[]
        {
            null,
            null
        };
    }

    public static ListNode CreateLinkedList(int[] nodes)
    {
        var lastNode = new ListNode(nodes[^1]);

        for (int j = nodes.Length - 2; j >= 0; j--)
        {
            var newNode = new ListNode(nodes[j], lastNode);

            lastNode = newNode;
        }

        return lastNode;
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(ListNode head, ListNode expectedHead)
    {
        var solution = new Solution();

        var output = solution.ReverseList(head);

        output.Should().BeEquivalentTo(expectedHead);
    }
}