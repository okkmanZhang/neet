public class MedianFinder
{

    private PriorityQueue<int, int> large;
    private PriorityQueue<int, int> small;
    public MedianFinder()
    {
        large = new PriorityQueue<int, int>();
        small = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
    }

    public void AddNum(int num)
    {
        if (small.Count >= large.Count)
        {
            small.Enqueue(num, num);
            var key = small.Dequeue();
            large.Enqueue(key, key);
        }
        else
        {
            large.Enqueue(num, num);
            var key = large.Dequeue();
            small.Enqueue(key, key);
        }
    }

    public double FindMedian()
    {
        if (large.Count < small.Count)
        {
            return small.Peek();
        }
        else if (large.Count > small.Count)
        {
            return large.Peek();
        }

        return (large.Peek() + small.Peek()) / 2.0;
    }
}
