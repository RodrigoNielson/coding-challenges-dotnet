using FluentAssertions;
using coding_challenges_dotnet.Easy.EvaluateBooleanBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace coding_challenges_dotnet_test.Easy;
public class EvaluateBooleanBinaryTreeTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            CreateTreeExample(),
            true
        };
    }

    public static TreeNode CreateTreeExample()
    {
        var n1 = new TreeNode(0);
        var n2 = new TreeNode(1);
        var n3 = new TreeNode(3, n1, n2);
        var n4 = new TreeNode(1);
        var root = new TreeNode(2, n4, n3);

        return root;
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(TreeNode root, bool expectedOutput)
    {
        var solution = new Solution();

        var output = solution.EvaluateTree(root);

        output.Should().Be(expectedOutput);
    }
}