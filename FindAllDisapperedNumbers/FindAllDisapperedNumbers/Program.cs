https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/

var inArray = new[] {4, 2, 3, 3, 5, 1, 2};
var outList = new List<int>();

for (int i = 0; i < inArray.Length; i++)
{
    var index = Math.Abs(inArray[i]) - 1;
    if (inArray[index] > 0)
    {
        inArray[index] *= -1;
    }
}

for (int i = 0; i < inArray.Length; i++)
{
    if (inArray[i] > 0)
    {
        outList.Add(i+1);
    }
}

foreach (var i in outList)
{
    Console.WriteLine(i);
}