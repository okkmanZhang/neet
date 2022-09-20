using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _49GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();            
            Dictionary<int, int> checkedStr = new Dictionary<int, int>();

            int xorChar(string a, string b)
            {
                if (a.Length != b.Length) { return 1; }
                Dictionary<char, int> mapa = new Dictionary<char, int>();
                
                for(int i=0; i<a.Length; i++)
                {
                    if (mapa.ContainsKey(a[i])) { mapa[a[i]]++; } else { mapa.Add(a[i], 1); }
                }
                
                for (int i = 0; i < b.Length; i++)
                {
                    if(!mapa.ContainsKey(b[i]))
                    {
                        return 1;
                    } else
                    {
                        mapa[b[i]]--;
                    }
                }

                return mapa.Any(m => m.Value > 0) ? 1 : 0;
            }


            for(int i = 0; i < strs.Length; i++)
            {
                if(checkedStr.ContainsKey(i)) { continue; }

                IList<string> anag = new List<string>();
                anag.Add(strs[i]);
                
                for (int j = i+1; j < strs.Length; j++)
                {
                    if (xorChar(strs[i], strs[j]) == 0)
                    {
                        anag.Add(strs[j]);
                        checkedStr.Add(j, 0);
                    }
                }

                res.Add(anag);
            }

            return res;
        }

        
    }
}
