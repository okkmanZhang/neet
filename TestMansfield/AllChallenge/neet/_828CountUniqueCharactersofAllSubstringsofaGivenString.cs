using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _828CountUniqueCharactersofAllSubstringsofaGivenString
    {
        public int UniqueLetterString(string s)
        {
            int res = 0;
            int len = s.Length;
            if (s == null || s.Length == 0)
            {
                return res;
            }

            int[] showLastPosition = new int[128];
            int[] contribution = new int[128];

            int cur = 0;

            for (int i = 0; i < len; i++)
            {
                char x = s[i];
                cur -= contribution[x];
                contribution[x] = (i - (showLastPosition[x] - 1));
                cur += contribution[x];
                showLastPosition[x] = i + 1;

                res += cur;
            }

            return res;
        }
    }
}
