namespace ClassLibrary1
{
    public class _172FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            int res = 0;
            for (int i = n; i > 1; i = i/5)
            {
                res+=i/5;
            }
            return res;
        }
    }
}