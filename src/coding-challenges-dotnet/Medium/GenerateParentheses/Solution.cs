namespace coding_challenges_dotnet.Medium.GenerateParentheses;

/// <see cref="https://leetcode.com/problems/generate-parentheses/"/>
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var results = new List<string>();

        GenerateParenthesisRecursive(n, 0, string.Empty, ref results); ;

        return results;
    }

    public void GenerateParenthesisRecursive(int l, int openCount, string result, ref List<string> results)
    {
        if (l == 0 && openCount == 0)
        {
            results.Add(result);
            return;
        }

        if (l > 0 && openCount >= 0)
            GenerateParenthesisRecursive(l - 1, openCount + 1, result + "(", ref results);

        if (openCount > 0)
            GenerateParenthesisRecursive(l, openCount - 1, result + ")", ref results);
    }
}