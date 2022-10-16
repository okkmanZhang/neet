namespace ClassLibrary1
{
    public class _5LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int left = 0;
            int right = -1;
            string longP = "";

            if (s.Length == 0) return "";
            if (s.Length == 1) return s;

            while (left < s.Length - 1)
            {
                if (right - left < 0)
                {
                    right++;
                    continue;
                }

                var currentStr = s.Substring(left, right - left + 1);
                if (this.IsPal(currentStr) && currentStr.Length > longP.Length)
                {
                    longP = currentStr;
                }

                if (right < s.Length - 1)
                {
                    right++;
                    continue;
                }

                if (right == s.Length - 1)
                {
                    right = -1;
                    left++;
                    continue;
                }
            }


            return longP;
        }

        public bool IsPal(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }

            int mid = s.Length % 2 == 0 ? s.Length / 2 : (s.Length / 2) + 1;

            for (int i = 0; i < mid; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                { return false; }
            }

            return true;

        }

        string FindPalindrome(string s, int l, int r)
        {
            while (l >=0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            return s.Substring(l + 1, r-l-1);
        }

        public string LongestPalindromeDoublePoints(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                var s1 = FindPalindrome(s, i, i);
                var s2 = FindPalindrome(s, i, i + 1);

                res = res.Length > s1.Length ? res : s1;
                res = res.Length > s2.Length ? res : s2;
            }

            return res;

        }
    }


}