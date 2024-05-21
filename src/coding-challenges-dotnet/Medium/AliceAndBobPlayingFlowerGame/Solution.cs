namespace coding_challenges_dotnet.Medium.AliceAndBobPlayingFlowerGame;

/// <see cref="https://leetcode.com/problems/alice-and-bob-playing-flower-game/"/>
public class Solution
{
    public long FlowerGame(int n, int m)
    {
        // overengineering, after checking the solutions this could just rewritten as: return ((long)n*m)/2;
        
        if (n % 2 == 0)
            return m * ((long)n / 2);

        if (m % 2 == 0)
            return n * ((long)m / 2);

        if (n > m)
        {
            n--;

            long result = m * ((long)n / 2);

            if (m != 1)
                result += m / 2;

            return result;
        }
        else
        {
            m--;

            long result = n * ((long)m / 2);
            if (n != 1)
                result += n / 2;

            return result;
        }
    }
}