using coding_challenges_dotnet.Easy.ContainsDuplicate;
using FluentAssertions;
using Xunit;

namespace coding_challenges_dotnet_test.Easy;
public class ContainsDuplicateTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            new int[] { 1, 2, 3, 1 },
            true
        };

        // Example 2:
        yield return new object[]
        {
            new int[] { 1, 2, 3, 4 },
            false
        };

        // Example 3:
        yield return new object[]
        {
            new int[] { 1,1,1,3,3,4,3,2,4,2 },
            true
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, bool expectedOutput)
    {
        var solution = new Solution();

        var output = solution.ContainsDuplicate(nums);

        output.Should().Be(expectedOutput);
    }
}

