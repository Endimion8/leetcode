https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/

var inList = new List<int> {4, 2, 3, 3, 5, 1, 2};
var set = new HashSet<int>(inList);
var outList = new List<int>();
for (int i = 1; i <= inList.Count; i++)
{
    if (!set.Contains(i + 1))
    {
        outList.Add(i+1);
    }
}

foreach (var i in outList)
{
    Console.WriteLine(i);
}