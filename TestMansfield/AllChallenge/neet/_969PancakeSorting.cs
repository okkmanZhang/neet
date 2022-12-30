namespace ClassLibrary1
{
    public class _969PancakeSorting
    {
        public IList<int> PancakeSort(int[] arr)
        {
            int n = arr.Length;
            IList<int> res = new List<int>();

            Sort(n);

            void Sort(int n)
            {
                if (n == 1) return;

                int maxIndex = -1;
                int max = -1;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        maxIndex = i;
                    }
                }

                Reverse(0,maxIndex);                
                res.Add(maxIndex + 1);
                Reverse(0,n-1);
                res.Add(n);

                Sort(n - 1);
            }

            void Reverse(int i,int j)
            {
                while(i<j)
                {
                    int temp = arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                    i++;
                    j--;
                }
            }

            return res;
        }
    }
}