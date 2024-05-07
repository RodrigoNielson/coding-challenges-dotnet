using FluentAssertions;
using leetcode_dotnet.Easy.Convert1DArrayInto2DArray;
using Xunit;

namespace leetcode_dotnet_test.Easy;
public class Convert1DArrayInto2DArrayTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            new int[] { 1, 2, 3, 4 },
            2,
            2,
            new int[][]
            {
                [1, 2],
                [3, 4]
            },
        };

        // Example 2:
        yield return new object[]
        {
            new int[] { 1, 2, 3 },
            1,
            3,
            new int[][]
            {
                [1, 2, 3]
            }
        };

        // Example 3:
        yield return new object[]
        {
            new int[] { 1, 2 },
            1,
            1,
            Array.Empty<int[]>()
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] arr1, int m, int n, int[][] expectedOutput)
    {
        var solution = new Solution();

        var output = solution.Construct2DArray(arr1, m, n);

        output.Should().BeEquivalentTo(expectedOutput, opt => opt.WithStrictOrdering());
    }
}

