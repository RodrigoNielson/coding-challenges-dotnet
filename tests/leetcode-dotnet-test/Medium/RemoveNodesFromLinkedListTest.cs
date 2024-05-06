using FluentAssertions;
using leetcode_dotnet.Medium.RemoveNodesFromLinkedList;
using Xunit;

namespace leetcode_dotnet_test.Medium;
public class RemoveNodesFromLinkedListTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            CreateLinkedList([5, 2, 13, 3, 8]),
            CreateLinkedList([13, 8])
        };

        // Example 2:
        yield return new object[]
        {
            CreateLinkedList([1, 1, 1, 1]),
            CreateLinkedList([1, 1, 1, 1])
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

        var output = solution.RemoveNodes(head);

        output.Should().BeEquivalentTo(expectedHead); 
    }
}