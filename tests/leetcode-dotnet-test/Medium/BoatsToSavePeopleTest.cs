using FluentAssertions;
using leetcode_dotnet.Medium.BoatsToSavePeople;
using Xunit;

namespace leetcode_dotnet_test.Medium;
public class BoatsToSavePeopleTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            new int[] { 1, 2 },
            3,
            1
        };

        // Example 2:
        yield return new object[]
        {
            new int[] { 3, 2, 2, 1 },
            3,
            3
        };

        // Example 3:
        yield return new object[]
        {
            new int[] { 3, 5, 3, 4 },
            4,
            4
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] people, int limit, int expectedOutput)
    {
        var solution = new Solution();

        var output = solution.NumRescueBoats(people, limit);

        output.Should().Be(expectedOutput);
    }
}