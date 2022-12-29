namespace ClassLibrary1
{
    public class _792NumberOfMatchingSubsequences
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            List<int>[] index = new List<int>[256];
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (index[c] == null)
                {
                    index[c] = new List<int>();
                    index[c].Add(i);
                }
                else
                {
                    index[c].Add(i);
                }
            }

            foreach (var item in index)
            {
                if (item!=null) Console.WriteLine(string.Join(",", item));
            }

            int res = 0;
            foreach (var item in words)
            {
                int i = 0, j = 0;
                for (; i < item.Length; i++)
                {
                    var c = item[i];
                    if (index[c] == null)
                    {
                        break;
                    }

                    int pos = Left_Bound(index[c], j);
                    if (pos == -1)
                    {
                        break;
                    }
                    j = index[c][pos] + 1;
                }

                if (i == item.Length) res++;
            }

            return res;
        }

        private int Left_Bound(List<int> arr, int target)
        {
            int left = 0, right = arr.Count;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            if (left == arr.Count)
            {
                return -1;
            }
            return left;
        }
    }
}