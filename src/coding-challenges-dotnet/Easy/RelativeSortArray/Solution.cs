using System.Collections;

namespace coding_challenges_dotnet.Easy.RelativeSortArray;

/// <see cref="https://leetcode.com/problems/relative-sort-array/description/"/>
public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var indexValue = new Dictionary<int, int>();

        for (int i = 0; i < arr2.Length; i++)
        {
            indexValue.Add(arr2[i], i - 1000);
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (indexValue.TryGetValue(arr1[i], out var value))
                arr1[i] = value;
        }

        Array.Sort(arr1);

        for (int i = 0; i < arr1.Length; i++)
        {
            var index = arr1[i] + 1000;

            if (index < arr2.Length)
                arr1[i] = arr2[index];
        }

        return arr1;
    }
}
