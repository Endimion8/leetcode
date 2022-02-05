namespace FlattenNestedListIterator._341;

public class NestedIterator
{
    private int Position { get; set; } = -1;
    private List<int> FlattenedList { get; }

    public NestedIterator(IList<NestedInteger> nestedList) {
        FlattenedList = new List<int>();
        
        foreach (var nestedInteger in nestedList)
        {
            FlattenList(nestedInteger);
        }
    }

    private void FlattenList(NestedInteger nestedInteger)
    {
        if (nestedInteger.IsInteger())
        {
            FlattenedList.Add(nestedInteger.GetInteger());
            return;
        }

        var list = nestedInteger.GetList();
        foreach (var next in list)
        {
            FlattenList(next);
        }
    }

    public bool HasNext()
    {
        return Position < FlattenedList.Count - 1;
    }

    public int Next() {
        if (HasNext())
        {
            Position++;
            return FlattenedList[Position];
        }

        return Int32.MinValue;
    }
}