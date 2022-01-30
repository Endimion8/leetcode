// See https://aka.ms/new-console-template for more information

var node = new TreeNode(4, new TreeNode(2), new TreeNode(5));
const int k = 1;

var values = new List<int>();

TreeNode.InOrderTraversal(node, val => values.Add(val));

Console.WriteLine(values[k-1]);