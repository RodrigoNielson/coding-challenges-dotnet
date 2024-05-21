namespace coding_challenges_dotnet.Easy.RemoveDuplicatesFromSortedArray;

/// <see cref="https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/"/>
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int j = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[j++] = nums[i];
            }
        }

        return j;
    }
}
