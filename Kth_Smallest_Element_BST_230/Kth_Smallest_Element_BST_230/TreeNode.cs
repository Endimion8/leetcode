
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

    public static int KthSmallest(TreeNode? node, int k)
    {
        var stack = new Stack<TreeNode?>();
        var root = node;

        while (true)
        {
            // спускаемся к самому левому потомку
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            if (--k == 0)
            {
                return root!.val;
            }
            
            // ищем в правом потомке
            root = root!.right;
        }
    }
}