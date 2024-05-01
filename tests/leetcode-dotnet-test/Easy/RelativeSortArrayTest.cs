using FluentAssertions;
using leetcode_dotnet.Easy.RelativeSortArray;
using Xunit;

namespace leetcode_dotnet_test.Easy;

public class RelativeSortArrayTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 },
            new int[] { 2, 1, 4, 3, 9, 6 },
            new int[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 }
        };

        // Example 2:
        yield return new object[]
        {
            new int[] { 28, 6, 22, 8, 44, 17 },
            new int[] { 22, 28, 8, 6 },
            new int[] { 22, 28, 8, 6, 17, 44 }
    };
    }

    /// <summary>
    /// Runtime: 102ms - Beats 55.78% of users with C#
    /// Memory: 45.88mb - Beats 39.456% of users with C#
    /// </summary>
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] arr1, int[] arr2, int[] expectedOutput)
    {
        var solution = new Solution();

        var output = solution.RelativeSortArray(arr1, arr2);

        output.Should().BeEquivalentTo(expectedOutput, opt => opt.WithStrictOrdering());
    }
}