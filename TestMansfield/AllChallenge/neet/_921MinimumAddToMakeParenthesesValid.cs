namespace ClassLibrary1
{
    public class _921MinimumAddToMakeParenthesesValid
    {
        public int MinAddToMakeValid(string s)
        {
            return IsValid(s);
        }

        private int IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            int res =0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count > 0 && LeftOf(s[i]) == stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    res++;
                    //return false;
                }
            }

            return res+ stack.Count;
        }

        private char LeftOf(char c)
        {
            if (c == ')') return '(';
            if (c == ']') return '[';
            return '{';
        }
    }
}