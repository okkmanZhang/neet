public class _739DailyTemperature
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] res = new int[n];
        Stack<int> s = new Stack<int>();

        for (int i = n - 1; i >= 0; i--)
        {
            while (s.Count() > 0 && temperatures[s.Peek()] <= temperatures[i])
            {
                s.Pop();
            }

            res[i] = s.Count() == 0 ? 0 : (s.Peek()-i);
            s.Push(i);
        }

        return res;
    }
}