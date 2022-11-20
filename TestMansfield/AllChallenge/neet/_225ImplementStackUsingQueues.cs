public class MyStack
{

    Queue<int> q1;
    Queue<int> q2;
    public MyStack()
    {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }

    public void Push(int x)
    {
        q1.Enqueue(x);
    }

    public int Pop()
    {
        Top();
        var res = q1.Dequeue();

        while (q2.Count() > 0)
        {
            q1.Enqueue(q2.Dequeue());
        }
        return res;
    }

    public int Top()
    {
        if (q1.Count() > 1)
        {
            while (q1.Count() > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
        }
        return q1.Peek();
    }

    public bool Empty()
    {
        return q1.Count == 0 && q2.Count == 0;
    }
}
