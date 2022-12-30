namespace ClassLibrary1
{
    public class _224BasicCalculator
    {
        public int Calculate(string s)
        {

            s = s.Replace(" ", "");
            return Helper(s.ToList<char>());
        }

        int Helper(List<char> deque)
        {
            char sign = '+';
            Stack<int> stack = new Stack<int>();
            int num = 0;

            while (deque.Count > 0)
            {
                
                char c = deque[0];
                deque.RemoveAt(0);

                
                if (IsDigit(c))
                {
                    num = num * 10 + (c - '0');
                }

                if (c == '(')
                {
                   
                    num = Helper(deque);
                }

                if (!IsDigit(c) || deque.Count == 0)
                {
                    if (sign == '+')
                    {
                        stack.Push(num);
                    }
                    else if (sign == '-')
                    {
                        stack.Push(-num);
                    }
                    else if (sign == '*')
                    {
                        int pre = stack.Pop();
                        stack.Push(pre * num);
                    }
                    else if (sign == '/')
                    {
                        int pre = stack.Pop();
                        stack.Push(pre / num);
                    }
                    num = 0;
                    sign = c;
                }

                if (c == ')')
                {
                    break;
                }
            }

            int res = 0;
            while (stack.Count > 0)
            {
                int top = stack.Pop();
                res += top;
            }
            return res;
        }

        bool IsDigit(char c)
        {
            if (c >= '0' && c <= '9') return true;

            return false;
        }
    }
}