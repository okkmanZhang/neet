using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class _1817FindingtheUsersActiveMinutes
    {
        public int[] FindingUsersActiveMinutes(int[][] logs, int k)
        {           

            Dictionary<int, HashSet<int>> _uam = new Dictionary<int, HashSet<int>>();
            int[] res = Enumerable.Repeat(0, k).ToArray();

            foreach(var action in logs)
            {
                if(_uam.ContainsKey(action[0]))
                {
                    _uam[action[0]].Add(action[1]);
                }else
                {
                    _uam.Add(action[0], new HashSet<int>() { action[1] });
                }
            }

            
            foreach(var userid in _uam.Keys)
            {
                res[_uam[userid].Count()-1]++;
                
            }

            return res;
        }
    }
}
