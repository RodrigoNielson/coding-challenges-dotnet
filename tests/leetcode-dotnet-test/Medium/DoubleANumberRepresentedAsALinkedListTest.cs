using FluentAssertions;
using leetcode_dotnet.Medium.DoubleANumberRepresentedAsALinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode_dotnet_test.Medium;
public class DoubleANumberRepresentedAsALinkedListTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            CreateLinkedList([1, 8, 9]),
            CreateLinkedList([3, 7, 8])
        };

        // Example 2:
        yield return new object[]
        {
            CreateLinkedList([9, 9, 9]),
            CreateLinkedList([1, 9, 9, 8])
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

        var output = solution.DoubleIt(head);

        output.Should().BeEquivalentTo(expectedHead);
    }
}