using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at
{
    /* easy version
     [input] "A", "C", "B", "C", "B", "A"
     [output] A B C

    explanation:
    A: 3 votes, B C: 2 votes but B precedes C alphabetically.
     */

    /* hard version
    [input] votes[]: "ABC", "BCA", "CAB", "ACB"           
    [output] A C B

    explanation:    
    A 2 1 1
    B 1 1 2
    C 1 2 1
    A got 2 votes for first place.
    B and C got 1 vote for second place but B precedes C alphabetically.
     */
    public class VoteRanking
    {
        public string RankTeamsEasyVersion(string[] votes)
        {
            var voteGroup = votes.ToList().GroupBy(g => g).ToList();
            voteGroup.Sort((a, b) => a.Count() == b.Count() 
                ? a.Key.CompareTo(b.Key) 
                : b.Count() - a.Count());

            return String.Join("", voteGroup.Select(s => s.Key));
        }

        public string RankTeamsHardVersion(string[] votes)
        {
            //<team, vote[]>
            var teamVoteMap = new Dictionary<char, int[]>();

            //initilse
            //<'A', [0,0,0]>
            foreach (var iChar in votes[0])
            {
                teamVoteMap[iChar] = Enumerable.Repeat(0, votes[0].Length).ToArray();
            }

            //fill the hashmap
            foreach (var vote in votes)
            {
                //ABC
                for (int i = 0; i < vote.Length; i++)
                {
                    //A: vote[], i = position
                    teamVoteMap[vote[i]][i]++;
                }
            }

            //sort teams
            var sortedTeam = teamVoteMap.Keys.ToList();
            sortedTeam.Sort((a, b) =>
            {
                //A 2 1 1
                //B 1 1 2
                var votesA = teamVoteMap[a];
                var votesB = teamVoteMap[b];

                for (int i = 0; i < votesA.Length; i++)
                {
                    if (votesA[i] > votesB[i])
                    {
                        return -1;
                    }
                    if (votesA[i] < votesB[i])
                    {
                        return 1;
                    }
                }

                //sort alphabetically
                return a.CompareTo(b);
            });

            return String.Concat(sortedTeam);
        }
    }
}
