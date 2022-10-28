public class _3LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {

        int[] freqs = new int[256];
        int l = 0, r = -1;
        int maxLen = 0;
        while (l < s.Length)
        {

            if (r < s.Length - 1 && freqs[s[r + 1]] == 0)
            {
                r++;
                freqs[s[r]]++;
            }
            else
            {
                freqs[s[l]]--;
                l++;
            }
            maxLen = Math.Max(maxLen, r - l + 1);
        }

        return maxLen;
    }

    public int LengthOfLongestSubstringSlideWindow(string s)
    {


        Dictionary<char, int> window = new Dictionary<char, int>();

        int res = 0;
        int left = 0, right = 0;

        while (right < s.Length)
        {
            char c = s[right];
            right++;

            if (window.ContainsKey(c))
                window[c]++;
            else
                window.Add(c, 1);

            while (window[c] > 1)
            {
                char d = s[left];
                left++;
                window[d]--;
            }

            res= Math.Max(res,right-left);
        }

        return res;

    }
}