using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class _1152AnalyzeUserWebsiteVisitPattern
    {
        public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
        {
            IList<string> res = new List<string>();

            //{user, patterns}
            HashSet<string> userPatterns = new HashSet<string>();

            List<(string, int, string)> ts = new List<(string, int, string)>();

            for (int i = 0; i < username.Length; i++)
            {
                (string, int, string) newt = (username[i], timestamp[i], website[i]);
                ts.Add(newt);
            }


            string[] GetPatterns(List<string> groupSites, string key)
            {
                List<string> res = new List<string>();

                for(int i = 0; i < groupSites.Count -2; i++)
                {
                    for( int j = i+1; j < groupSites.Count; j++)
                    {
                        for (int k = j+1; k < groupSites.Count; k++)
                        {
                            res.Add(key + "-" + groupSites[i] + "-" + groupSites[j] + "-" + groupSites[k]);
                        }
                    }
                }

                return res.ToArray();
            }

            var tsGroup = ts.GroupBy(s => s.Item1);

            foreach (var iGroup in tsGroup)
            {
                if (iGroup.Count() < 3) continue;
                
                if (iGroup.Count() == 3)
                {
                    userPatterns.Add(iGroup.Key + "-" + string.Join('-',  iGroup.OrderBy(b => b.Item2).Select(s => s.Item3).ToArray()));
                }
                else
                {
                    foreach(string iStr in GetPatterns(iGroup.OrderBy(b => b.Item2).Select(s => s.Item3).ToList(), iGroup.Key))
                    {
                        userPatterns.Add(iStr);
                    }

                    
                }
            }

            var user2 = userPatterns
                .Select(s => string.Join("-", s.Split('-').Skip(1)))
                .ToList();

            var user3 = user2.GroupBy(g => g)
            .OrderByDescending(b => b.Count())
            .ThenBy(b => b.Key)
            .Select(s => s.Key).ToList();

            var s = user3.FirstOrDefault();
            return s.Split('-').ToList();            
        }
    }
}
