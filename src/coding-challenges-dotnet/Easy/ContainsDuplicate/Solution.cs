namespace coding_challenges_dotnet.Easy.ContainsDuplicate;

/// <see cref="https://leetcode.com/problems/contains-duplicate/"/>
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var existingNums = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (existingNums.Contains(nums[i]))
                return true;

            existingNums.Add(nums[i]);
        }

        return false;
    }
}