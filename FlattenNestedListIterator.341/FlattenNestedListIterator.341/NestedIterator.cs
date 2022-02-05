namespace FlattenNestedListIterator._341;

public class NestedIterator
{
    private class ListPosition
    {
        public IList<NestedInteger> List { get; set; }
        public int NextPosition { get; set; }
        public ListPosition(IList<NestedInteger> list, int nextPosition)
        {
            List = list;
            NextPosition = nextPosition;
        }
    }

    private Stack<ListPosition> Positions { get; set; } = new();

    private int Current { get; set; }
    private bool CurrentFilled { get; set; } = false;

    public NestedIterator(IList<NestedInteger> nestedList) {
        Positions.Push(new ListPosition(nestedList, 0));
    }

    private void FillCurrent()
    {
        if (CurrentFilled)
        {
            return;
        }

        while (true)
        {
            if (Positions.Count < 1)
            {
                return;
            }
            
            var list = Positions.Peek().List;
            var nextPosition = Positions.Peek().NextPosition;
            
            if (nextPosition >= list.Count)
            {
                Positions.Pop();
                continue;
            }

            if (list[nextPosition].IsInteger())
            {
                Current = list[nextPosition].GetInteger();
                CurrentFilled = true;
                Positions.Peek().NextPosition++;
                return;
            }
            Positions.Peek().NextPosition++;
            Positions.Push(new ListPosition(list[nextPosition].GetList(), 0));
        }
    }
    public bool HasNext()
    {
        FillCurrent();
        return CurrentFilled;
    }

    public int Next() {
        FillCurrent();
        
        if (CurrentFilled)
        {
            CurrentFilled = false;
            return Current;
        }

        throw new InvalidOperationException();
    }
}