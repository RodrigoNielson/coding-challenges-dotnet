namespace leetcode_dotnet.Easy.Convert1DArrayInto2DArray;

/// <see cref="https://leetcode.com/problems/convert-1d-array-into-2d-array/description/"/>
public class Solution
{
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (original.Length != m * n)
            return [];

        var result = new int[m][];

        for (int i = 0; i < m; i++)
        {
            var index = i * n;
            var finalIndex = index + n;
            result[i] = original[index..finalIndex];
        }

        return result;
    }
}
