using System;
using System.Collections.Generic;
using System.Linq;

namespace MinStack
{
    // https://leetcode.com/problems/min-stack/
    public class MinStack {
        private Stack<int> Stack { get; }
        private Stack<int> MinimumsStack { get; }

        public MinStack()
        {
            Stack = new Stack<int>();
            MinimumsStack = new Stack<int>();
        }
    
        public void Push(int val)
        {
            Stack.Push(val);

            int currentMinimum;
            bool isEmpty = !MinimumsStack.TryPeek(out currentMinimum);

            if (isEmpty)
            {
                MinimumsStack.Push(val);
                return;
            }
            
            if (val < currentMinimum)
            {
                MinimumsStack.Push(val);
            }
            else
            {
                MinimumsStack.Push(currentMinimum);
            }
        }
    
        public void Pop()
        {
            int result;
            int minimum;
            Stack.TryPop(out result);
            MinimumsStack.TryPop(out minimum);
        }
    
        public int Top() {
            int result;
            Stack.TryPeek(out result);
            
            return result;
        }
    
        public int GetMin()
        {
            int minimum;
            MinimumsStack.TryPeek(out minimum);
            
            return minimum;
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}