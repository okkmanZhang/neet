using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _22GenerateParentheses
    {
        //backtrack
        public IList<string> GenerateParenthesis(int n)
        {
            Stack<char> stack = new Stack<char>();
            IList<string> result = new List<string>();

            void backtrack(int openN, int closedN)
            {
                if(openN == n && closedN == n)
                {
                    result.Add(string.Join("", stack.Reverse()));
                    return;
                }

                if(openN < n)
                {
                    stack.Push('(');
                    backtrack(openN + 1, closedN);
                    stack.Pop();
                }

                if(closedN < openN)
                {
                    stack.Push(')');
                    backtrack(openN, closedN + 1);
                    stack.Pop();
                }
            }

            backtrack(0, 0);
            return result;
        }
    }
}
