using System.Linq;

namespace ClassLibrary1
{
    public class _372SuperPow
    {
        int basem = 1337;
        int MyPow(int a, int k)
        {
            a %= basem;
            int res = 1;
            for (int _ = 0; _ < k; _++)
            {
                res *= a;
                res %= basem;
            }
            return res;
        }
        public int SuperPow(int a, int[] b)
        {
            if (b.Length == 0) return 1;
            int last = b.Last();
            b = b.SkipLast(1).ToArray();

            int p1 = MyPow(a, last);
            int p2 = MyPow(SuperPow(a, b), 10);

            return (p1 * p2) % basem;
        }
    }
}