using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _150EvaluateReversePolishNotation
    {
        //stack
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            int Eval(int p1, int p2, string c)
            {
                switch (c)
                {
                    case "+":
                        return p1 + p2;
                    case "-":
                        return p1 - p2;
                    case "*":
                        return p1 * p2;
                    case "/":
                        return p1 / p2;
                    default:
                        return 0;
                }
            }


            foreach (string c in tokens)
            {
                if (int.TryParse(c, out int parsed))
                {
                    stack.Push(parsed);
                }
                else
                {
                    int p2 = stack.Pop();
                    int p1 = stack.Pop();
                    stack.Push(Eval(p1, p2, c));
                }
            }

            return stack.Pop();
        }
    }
}
