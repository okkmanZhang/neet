public class _0005LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {

        int l = 0, r = -1;
        string maxStr = "";

        while (l < s.Length)
        {
            Console.WriteLine(l);
            Console.WriteLine(r + 1);
            Console.WriteLine(s.Substring(l, r + 1 - l + 1));
            Console.WriteLine(IsPal(s.Substring(l, r + 1 - l + 1)));

            if (r < s.Length && !IsPal(s.Substring(l, r + 1 - l + 1)))
            {
                r++;
            }
            else
            {
                maxStr = s.Substring(l, r - l + 1).Length > maxStr.Length ? s.Substring(l, r - l + 1) : maxStr;
                l++;
            }
        }

        return maxStr;
    }

    private bool IsPal(string ss)
    {

        int left = 0;
        int right = ss.Length - 1;


        while (left < right)
        {

            if (ss[left] != ss[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}