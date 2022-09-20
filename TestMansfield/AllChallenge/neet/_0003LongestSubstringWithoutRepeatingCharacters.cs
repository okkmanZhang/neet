public class _0003LongestSubstringWithoutRepeatingCharacters {
    public int LengthOfLongestSubstring(string s) {

        int[] freqs = new int[256];
        int l = 0, r = -1;
        int maxLen = 0;
        while(l < s.Length) {
            
            if (r < s.Length -1 && freqs[s[r+1]] == 0 ){
                r++;
                freqs[s[r]]++;
            }else{
                freqs[s[l]]--;
                l++;
            }
            maxLen = Math.Max(maxLen, r-l+1);
        }

        return maxLen;
    }
}