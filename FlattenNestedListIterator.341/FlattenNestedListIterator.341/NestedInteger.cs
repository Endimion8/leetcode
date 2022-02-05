namespace FlattenNestedListIterator._341;

public class NestedInteger
{
    // @return true if this NestedInteger holds a single integer, rather than a nested list.
    public bool IsInteger()
    {
        return true;
    }

    // @return the single integer that this NestedInteger holds, if it holds a single integer
    // Return null if this NestedInteger holds a nested list
    public int GetInteger()
    {
        return 0;
    }

    // @return the nested list that this NestedInteger holds, if it holds a nested list
    // Return null if this NestedInteger holds a single integer
    public IList<NestedInteger> GetList()
    {
        return new List<NestedInteger>();
    }
}