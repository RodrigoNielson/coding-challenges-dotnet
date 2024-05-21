namespace coding_challenges_dotnet.Easy.EvaluateBooleanBinaryTree;

/// <see cref="https://leetcode.com/problems/evaluate-boolean-binary-tree/description/"/>
public class Solution
{
    public bool EvaluateTree(TreeNode root)
    {
        if (root.val == 2)
            return EvaluateTree(root.left) || EvaluateTree(root.right);

        if (root.val == 3)
            return EvaluateTree(root.left) && EvaluateTree(root.right);

        return root.val == 1;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}