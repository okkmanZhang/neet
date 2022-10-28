namespace ClassLibrary1
{
    public class _567PermutationString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            Dictionary<char, int> need = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();

            foreach (var item in s1)
            {
                if (need.ContainsKey(item))
                    need[item]++;
                else
                    need.Add(item, 1);
            }

            int left = 0, right = 0;
            int valid = 0;

            while (right < s2.Length)
            {
                char c = s2[right];
                right++;

                if (need.ContainsKey(c))
                {
                    if (window.ContainsKey(c))
                        window[c]++;
                    else
                        window.Add(c,1);


                    if (window[c] == need[c])
                    {
                        valid++;
                    }
                }

                while (right - left >= s1.Length)
                {

                    if (valid == need.Keys.Count)
                    {
                        return true;
                    }

                    char d = s2[left];
                    left++;
                    if (need.ContainsKey(d))
                    {
                        if (window[d] == need[d])
                            valid--;

                        window[d]--;
                    }
                }

            }

            return false;
        }
    }
}