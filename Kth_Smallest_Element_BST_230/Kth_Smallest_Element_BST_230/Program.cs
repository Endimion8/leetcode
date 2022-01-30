// See https://aka.ms/new-console-template for more information

var node = new TreeNode(4, new TreeNode(2), new TreeNode(5));
const int k = 1;

var kthSmallest = TreeNode.KthSmallest(node, k);

Console.WriteLine(kthSmallest);