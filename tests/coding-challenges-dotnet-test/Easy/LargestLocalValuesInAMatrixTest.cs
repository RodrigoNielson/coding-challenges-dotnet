using FluentAssertions;
using coding_challenges_dotnet.Easy.LargestLocalValuesInAMatrix;
using Xunit;

namespace coding_challenges_dotnet_test.Easy;
public class LargestLocalValuesInAMatrixTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            new int[][]
            {
                [9, 9, 8, 1],
                [5, 6, 2, 6],
                [8, 2, 6, 4],
                [6, 2, 2, 2]
            },
            new int[][]
            {
                [9, 9],
                [8, 6]
            },
        };

        // Example 2:
        yield return new object[]
        {
            new int[][]
            {
                [1, 1, 1, 1, 1],
                [1, 1, 1, 1, 1],
                [1, 1, 2, 1, 1],
                [1, 1, 1, 1, 1],
                [1, 1, 1, 1, 1]
            },
            new int[][]
            {
                [2, 2, 2],
                [2, 2, 2],
                [2, 2, 2]
            },
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] grid, int[][] expectedOutput)
    {
        var solution = new Solution();

        var output = solution.LargestLocal(grid);

        output.Should().BeEquivalentTo(expectedOutput, opt => opt.WithStrictOrdering());
    }
}

