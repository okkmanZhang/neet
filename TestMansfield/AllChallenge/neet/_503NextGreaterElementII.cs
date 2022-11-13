public class _503NextGreaterElementII
{
    public int[] NextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n];
        Stack<int> s = new Stack<int>();

        for (int i = n*2 - 1; i >= 0; i--)
        {
            while (s.Count() > 0 && s.Peek() <= nums[i%n])
            {
                s.Pop();
            }

            res[i%n] = s.Count() == 0 ? -1 : s.Peek();
            s.Push(nums[i%n]);
        }

        return res;
    }
}