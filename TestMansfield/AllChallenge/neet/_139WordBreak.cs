using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _139WordBreak
    {
        //decision tree
        //dynamic programming
        //cache
        //backtrack  
        public bool WordBreak(string s, IList<string> wordDict)
        {
            bool[] dp = Enumerable.Repeat(false, s.Length + 1).ToArray();
            dp[s.Length] = true;

            for(int i = s.Length-1; i > -1; i--)
            {
                foreach( var w in wordDict)
                {
                    if ((i+w.Length) <= s.Length && s.Substring(i, w.Length) == w)
                    {
                        dp[i] = dp[i + w.Length];
                    }
                    if (dp[i])
                        break;
                }
            }

            return dp[0];

        }
    }
}
