public class _344ReverseString
{
    public void ReverseString(char[] s)
    {
        if (s.Length == 1) return;
        int half = s.Length / 2;

        for (int i = 0; i < half; i++)
        {
            char temp = s[i];
            int partner = s.Length - i -1;
            s[i] = s[partner];
            s[partner] = temp;
        }
    }
}