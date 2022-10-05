public class _28ImplementStrStr {
    public int StrStr(string haystack, string needle) {

        if (needle == "")
            return 0;

        if (needle.Length > haystack.Length)
            return -1;

        
        for (int i = 0; i < haystack.Length; i++)
        {
            bool found = true;
            for(int j =0; j < needle.Length; j++) {
                if (haystack[i+j] != needle[j])
                    found = false;
            }

            if (found)
                return i;

            if (haystack.Length-i<=needle.Length)
                break;
        }

        return -1;
    }
}