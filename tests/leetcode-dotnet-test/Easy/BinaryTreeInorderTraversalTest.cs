using FluentAssertions;
using leetcode_dotnet.Easy.BinaryTreeInorderTraversal;
using Xunit;

namespace leetcode_dotnet_test.Easy;
public class BinaryTreeInorderTraversalTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            CreateTreeExample1(),
            new List<int> { 1, 3, 2 }
        };

        // Example 2:
        yield return new object[]
        {
            null,
            new List<int>()
        };

        // Example 2:
        yield return new object[]
        {
            new TreeNode(1),
            new List<int> { 1 }
        };
    }

    public static TreeNode CreateTreeExample1()
    {
        var third = new TreeNode(3);
        var second = new TreeNode(2, third);
        var first = new TreeNode(1, null, second);

        return first;
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(TreeNode root, IList<int> expectedOutput)
    {
        var solution = new Solution();

        var output = solution.InorderTraversal(root);

        output.Should().BeEquivalentTo(expectedOutput, opts => opts.WithStrictOrdering());
    }
}