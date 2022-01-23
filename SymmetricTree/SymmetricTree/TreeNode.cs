namespace SymmetricTree;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    
    public bool IsSymmetric(TreeNode? root)
    {
        if (root is null)
        {
            return true;
        }

        var stack = new Stack<(TreeNode?, TreeNode?)>();
        stack.Push((root.left, root.right));
        
        while (stack.Count > 0)
        {
            var (left, right) = stack.Pop();
            if (left is null && right is null)
            {
                continue;
            }
            if (left is null || right is null)
            {
                return false;
            }
            if (left.val != right.val)
            {
                return false;
            }
            
            stack.Push((left.left, right.right));
            stack.Push((left.right, right.left));
        }

        return true;
    }
}