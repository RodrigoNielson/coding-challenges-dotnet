namespace coding_challenges_dotnet.Easy.ContainsDuplicateII;

/// <see cref="https://leetcode.com/problems/contains-duplicate-ii/description/"/>
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary.Add(nums[i], new List<int> { i });
                continue;
            }

            if (dictionary[nums[i]].Any(c => Math.Abs(c - i) <= k))
                return true;

            dictionary[nums[i]].Add(i);
        }

        return false;
    }
}