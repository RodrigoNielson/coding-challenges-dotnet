using FluentAssertions;
using leetcode_dotnet.Medium.GenerateParentheses;
using Xunit;

namespace leetcode_dotnet_test.Medium;
public class GenerateParenthesesTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            3,
            new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" }
        };

        // Example 2:
        yield return new object[]
        {
            1,
            new List<string> { "()" }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int n, List<string> expectedOutput)
    {
        var solution = new Solution();

        var output = solution.GenerateParenthesis(n);

        output.Should().BeEquivalentTo(expectedOutput);
    }
}