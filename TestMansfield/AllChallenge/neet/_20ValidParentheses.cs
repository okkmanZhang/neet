namespace LeetCodeTony
{
    public class _20ValidParentheses
    {
        public bool IsValid(string s)
        {            
            Dictionary<char,char> chars = new Dictionary<char, char>{
                {'(', ')'},
                {'[',']'},
                {'{','}'}
            };

            Stack<char> stack = new Stack<char>();

            foreach(char c in s) {
                if (chars.ContainsKey(c)) {
                    stack.Push(c);
                } else {
                    if (!stack.Any())
                        return false;

                    var pre = stack.Pop();
                    if (chars[pre] != c)
                        return false;
                }
            }

            if (stack.Any())
                return false;
            else
                return true;
        }
    }
}