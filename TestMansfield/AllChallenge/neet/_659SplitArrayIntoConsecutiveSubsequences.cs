namespace ClassLibrary1
{
    public class _659SplitArrayIntoConsecutiveSubsequences
    {
        public bool IsPossible(int[] nums)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            Dictionary<int, int> need = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (freq.ContainsKey(item))
                {
                    freq[item]++;
                }
                else
                {
                    freq.Add(item, 1);
                }
            }

            foreach (var item in nums)
            {
                if (freq[item] == 0) continue;

                if (need.ContainsKey(item) && need[item] > 0)
                {
                    freq[item]--;
                    need[item]--;

                    if (need.ContainsKey(item + 1))
                    {
                        need[item + 1]++;
                    }
                    else
                    {
                        need.Add(item + 1, 1);
                    }
                }
                else if (freq[item] > 0
                    && freq.ContainsKey(item + 1)
                    && freq[item + 1] > 0
                    && freq.ContainsKey(item + 2)
                    && freq[item + 2] > 0)
                {
                    freq[item]--;
                    freq[item + 1]--;
                    freq[item + 2]--;

                    if (need.ContainsKey(item + 3))
                    {
                        need[item + 3]++;
                    }
                    else
                    {
                        need.Add(item + 3, 1);
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}