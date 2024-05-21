namespace coding_challenges_dotnet.Medium.BoatsToSavePeople;

/// <see cref="https://leetcode.com/problems/boats-to-save-people/description/"/>
public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        if (people.Length == 1)
            return 1;

        Array.Sort(people);

        var i = 0;
        var j = people.Length - 1;
        var boats = 0;
        while (i <= j)
        {
            if (i == j || people[i] + people[j] <= limit)
            {
                i++;
            }

            j--;
            boats++;
        }

        return boats;
    }
}
