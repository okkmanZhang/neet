namespace ClassLibrary1
{
    public class _438FindAllAnagramsInAString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            Dictionary<char, int> need = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();

            foreach (var item in p)
            {
                if (need.ContainsKey(item))
                    need[item]++;
                else
                    need.Add(item, 1);
            }

            IList<int> res = new List<int>();
            int left = 0, right = 0;
            int valid = 0;

            while (right < s.Length)
            {
                char c = s[right];
                right++;

                if (need.ContainsKey(c))
                {
                    if (window.ContainsKey(c))
                        window[c]++;
                    else
                        window.Add(c, 1);


                    if (window[c] == need[c])
                    {
                        valid++;
                    }
                }

                while (right - left >= p.Length)
                {

                    if (valid == need.Keys.Count)
                    {
                        res.Add(left);
                    }

                    char d = s[left];
                    left++;
                    if (need.ContainsKey(d))
                    {
                        if (window[d] == need[d])
                            valid--;

                        window[d]--;
                    }
                }

            }

            return res;
        }
    }
}