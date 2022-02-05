namespace FlattenNestedListIterator._341;

public class NestedIterator
{
    private Stack<NestedInteger> _stack { get; set; } = new();

    public NestedIterator(IList<NestedInteger> nestedList) {
        for (int i = nestedList.Count - 1; i >= 0; i--)
        {
            _stack.Push(nestedList[i]);
        }
    }
    
    public bool HasNext()
    {
        while (_stack.Count > 0)
        {
            var top = _stack.Peek();
            if (top.IsInteger())
            {
                return true;
            }

            var topList = _stack.Pop().GetList();
            for (int i = topList.Count - 1; i >= 0; i--)
            {
                _stack.Push(topList[i]);
            }
        }

        return false;
    }

    public int Next() {
        if (HasNext())
        {
            return _stack.Pop().GetInteger();
        }

        throw new InvalidOperationException();
    }
}