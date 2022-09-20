public class MinStack {

    List<int> _stack;
    int topIndex = -1;
    public MinStack() {
        _stack = new List<int>();
    }
    
    public void Push(int val) {
        _stack.Add(val);
        topIndex += 1;
    }
    
    public void Pop() {
        if (topIndex < 0) return;

        _stack.RemoveAt(topIndex);
        topIndex -= 1;
    }
    
    public int Top() {
        return _stack[topIndex];
    }
    
    public int GetMin() {
        int min = int.MaxValue;
        for (int i = 0; i < _stack.Count(); i++)
        {
            min = Math.Min(min, _stack[i]);
        }

        return min;
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