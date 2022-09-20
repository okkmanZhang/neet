using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _91DecodeWays
    {
        //decision tree
        //dynamics
        public int NumDecodings(string s)
        {
            Dictionary<int, int> dp = new Dictionary<int, int>();
            dp.Add(s.Length, 1);

            int dfs( int i)
            {
                if (dp.ContainsKey(i))
                    return dp[i];
                if (s[i] == '0')
                    return 0;

                int res = dfs(i + 1);
                if (i+1 < s.Length 
                    && (s[i] == '1' || (s[i] == '2' && (s[i+1] >= '0' && s[i+1] <='6' ) ) ))
                {
                    res += dfs(i + 2);
                }
                dp[i] = res;
                return res;
            }

            return dfs(0);
        }

    }
}
