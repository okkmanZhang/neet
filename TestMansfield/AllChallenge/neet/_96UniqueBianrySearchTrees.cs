namespace ClassLibrary1
{
    public class _96UniqueBianrySearchTrees
    {
        public int NumTrees(int n)
        {
            memo = new int [n+1,n+1];
            return Count(1,n);
        }

        int[,] memo;
        int Count(int lo, int hi)
        {
            if (lo > hi) return 1;

            if (memo[lo, hi] != 0)
                return memo[lo, hi];

            int res = 0;
            for (int mid = lo; mid <= hi; mid++)
            {
                int left = Count(lo, mid - 1);
                int right = Count(mid + 1, hi);
                res += left * right;
            }

            memo[lo, hi] = res;

            return res;

        }
    }
}