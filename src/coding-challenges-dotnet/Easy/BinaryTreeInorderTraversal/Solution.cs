namespace coding_challenges_dotnet.Easy.BinaryTreeInorderTraversal;

/// <see cref="https://leetcode.com/problems/binary-tree-inorder-traversal/description/"/>
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null)
            return new List<int>();

        var result = new List<int>();
        var stack = new Stack<TreeNode>();

        stack.Push(root);

        var visited = new HashSet<TreeNode>();

        while (stack.TryPop(out var current))
        {
            if (current.left == null)
            {
                result.Add(current.val);

                if (current.right != null)
                    stack.Push(current.right);
            }
            else if (!visited.Contains(current))
            {
                stack.Push(current);
                stack.Push(current.left);
                visited.Add(current);
            }
            else
            {
                result.Add(current.val);
                if (current.right != null)
                    stack.Push(current.right);
            }
        }

        return result;
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