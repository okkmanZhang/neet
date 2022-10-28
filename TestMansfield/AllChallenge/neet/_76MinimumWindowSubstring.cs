namespace ClassLibrary1
{
    public class _76MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> need = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();

            foreach (var item in t)
            {
                if(need.ContainsKey(item))
                    need[item]++;
                else
                    need.Add(item,1);
            }

            int left = 0, right = 0;
            int valid = 0;
            int start = 0, len = int.MaxValue;
            while (right < s.Length)
            {
                char c = s[right];
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

                while (valid == need.Count)
                {
                    if (right - left < len)
                    {
                        start = left;
                        len = right - left;
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

            return len == int.MaxValue ? "" : s.Substring(start, len);
        }
    }
}