namespace ClassLibrary1
{
    public class _204CountPrimes
    {
        public int CountPrimes(int n)
        {
            bool[] isPrime = new bool[n];
            Array.Fill(isPrime, true);

            for (int i = 2; i * i < n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            int res = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i]) res++;
            }

            return res;
        }
    }
}