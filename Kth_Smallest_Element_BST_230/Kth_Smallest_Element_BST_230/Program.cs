// See https://aka.ms/new-console-template for more information

var node = new TreeNode(4, new TreeNode(2), new TreeNode(5));
var k = 1;
var currentNodeIndex = 0;
var value = 0;

TreeNode.InOrderTraversal(node, val =>
{
    currentNodeIndex++;
    if (currentNodeIndex == k)
    {
        value = val;
    }
});

Console.WriteLine(value);