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

            while (left < s.Length -1)
            {                
                if(right - left < 0)
                {
                    right++;
                    continue;
                }

                var currentStr = s.Substring(left, right - left +1);
                if (this.IsPal(currentStr) && currentStr.Length > longP.Length)
                {
                    longP = currentStr;  
                }

                if (right < s.Length -1)
                {
                    right++;
                    continue;
                }

                if(right == s.Length -1)
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
                if (s[i] != s[s.Length-1-i])
                { return false; }
            }

            return true;

        }
    }
}