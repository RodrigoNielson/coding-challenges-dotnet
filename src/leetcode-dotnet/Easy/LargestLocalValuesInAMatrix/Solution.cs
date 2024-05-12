namespace leetcode_dotnet.Easy.LargestLocalValuesInAMatrix;

/// <see cref="https://leetcode.com/problems/largest-local-values-in-a-matrix/"/>
public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        var result = new int[grid.Length - 2][];

        for (int i = 1; i < grid.Length - 1; i++)
        {
            result[i - 1] = new int[grid[i].Length - 2];

            for (int j = 1; j < grid.Length - 1; j++)
            {
                var maxValue = -1;
                for (int k = -1; k < 2; k++)
                {
                    for (int l = -1; l < 2; l++)
                    {
                        maxValue = Math.Max(maxValue, grid[i+k][j+l]);
                    }
                }

                result[i - 1][j - 1] = maxValue;
            }
        }

        return result;
    }
}