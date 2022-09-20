using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _131PalindromePartitioning
    {
        //backtracking
        //https://www.youtube.com/watch?v=3jvWodd7ht0&ab_channel=NeetCode
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> res = new List<IList<string>>();
            IList<string> part = new List<string>();

            void DFS(int i)
            {
                if (i >= s.Length)
                {
                    res.Add(part.ToArray().ToList());
                    return;
                }
                for (int j = i; j < s.Length; j++)
                {
                    if (IsPali(i, j))
                    {
                        part.Add(s.Substring(i, j - i +1));
                        DFS(j + 1);
                        part.RemoveAt(part.Count - 1);
                    }
                }
            }

            bool IsPali(int l, int r)
            {
                while (l < r)
                {
                    if (s[l] != s[r])
                    { return false; }
                    l++;
                    r--;
                }
                return true;
            }

            DFS(0);
            return res;
        }
    }
}
