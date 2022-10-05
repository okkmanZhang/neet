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
                if (openN == n && closedN == n)
                {
                    result.Add(string.Join("", stack.Reverse()));
                    return;
                }

                if (openN < n)
                {
                    stack.Push('(');
                    backtrack(openN + 1, closedN);
                    stack.Pop();
                }

                if (closedN < openN)
                {
                    stack.Push(')');
                    backtrack(openN, closedN + 1);
                    stack.Pop();
                }
            }

            backtrack(0, 0);
            return result;
        }

        public IList<string> GenerateParenthesis2(int n)
        {
            IList<string> res = new List<string>();
            string track = "";

            Backtrack(n,n);

            return res;

            void Backtrack(int left, int right)
            {
                if (left > right) return;
                if (left<0 || right <0) return;
                if (left==0 && right ==0)
                {
                    res.Add(new string(track));
                }

                track += '(';
                Backtrack(left-1,right);
                track=track.Substring(0,track.Length-1);

                track +=')';
                Backtrack(left,right-1);
                track=track.Substring(0,track.Length-1);
            }

        }

    }
}
