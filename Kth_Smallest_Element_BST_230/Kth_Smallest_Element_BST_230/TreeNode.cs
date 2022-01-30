
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

    public static void InOrderTraversal(TreeNode? node, Action<int> action)
    {
        if (node is not null)
        {
            InOrderTraversal(node.left, action);
            action(node.val);
            InOrderTraversal(node.right, action);
        }
    }
}