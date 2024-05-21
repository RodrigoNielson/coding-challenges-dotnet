using FluentAssertions;
using coding_challenges_dotnet.Medium.AliceAndBobPlayingFlowerGame;
using Xunit;

namespace coding_challenges_dotnet_test.Medium;
public class AliceAndBobPlayingFlowerGameTest
{
    public static IEnumerable<object[]> GetData()
    {
        // Example 1
        yield return new object[]
        {
            3,
            2,
            3
        };

        // Example 2:
        yield return new object[]
        {
            1,
            1,
            0
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int m, int n, int expectedOutput)
    {
        var solution = new Solution();

        var output = solution.FlowerGame(m, n);

        output.Should().Be(expectedOutput);
    }
}