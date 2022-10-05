public class _125ValidPalindrome {
    public bool IsPalindrome(string s) {
        
        char[] ss = s.ToLower().Where(c => (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9')).ToArray();

        Console.WriteLine(string.Join(",",ss));

        if (ss.Length <= 1) return true;

        int left = 0;
        int right = ss.Length-1;


        while (left < right){

            if (ss[left] != ss[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}