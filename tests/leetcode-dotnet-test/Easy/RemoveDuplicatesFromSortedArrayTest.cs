using FluentAssertions;
using leetcode_dotnet.Easy.RemoveDuplicatesFromSortedArray;
using Xunit;

namespace leetcode_dotnet_test.Easy;
public class RemoveDuplicatesFromSortedArrayTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            new int[] { 1, 1, 2 },
            new int[] { 1, 2, 0 },
            2
        };

        // Example 2:
        yield return new object[]
        {
            new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
            new int[] { 0, 1, 2, 3, 4, 0, 0, 0, 0, 0},
            5
        };
    }

    /// <summary>
    /// 
    /// 
    /// </summary>
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int[] expectedNums, int expectedOutput)
    {
        var solution = new Solution();

        var output = solution.RemoveDuplicates(nums);

        output.Should().Be(expectedOutput);

        nums[..expectedOutput].Should().BeEquivalentTo(expectedNums[..expectedOutput], opt => opt.WithStrictOrdering());
    }
}