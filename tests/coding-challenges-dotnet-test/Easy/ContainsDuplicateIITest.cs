using coding_challenges_dotnet.Easy.ContainsDuplicateII;
using FluentAssertions;
using Xunit;

namespace coding_challenges_dotnet_test.Easy;
public class ContainsDuplicateIITest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            new int[] { 1, 2, 3, 1 },
            3,
            true
        };

        // Example 2:
        yield return new object[]
        {
            new int[] { 1,0,1,1 },
            1,
            true
        };

        // Example 3:
        yield return new object[]
        {
            new int[] { 1,2,3,1,2,3 },
            2,
            false
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int k, bool expectedOutput)
    {
        var solution = new Solution();

        var output = solution.ContainsNearbyDuplicate(nums, k);

        output.Should().Be(expectedOutput);
    }
}

