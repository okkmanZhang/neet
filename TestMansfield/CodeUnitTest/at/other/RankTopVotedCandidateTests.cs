using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllChallenge.at;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Tests
{
    [TestClass()]
    public class RankTopVotedCandidateTests
    {

        //private RankTopVotedCandidate911 rankTop = new RankTopVotedCandidate911(
        //    new int[] { 0, 0, 1, 1, 2 },
        //    new int[] { 0, 67, 69, 74, 87 });

        /*        private RankTopVotedCandidate911 rankTop = new RankTopVotedCandidate911(
                    new int[] { 0, 0, 0, 0, 1 },
                    new int[] { 0, 6, 39, 52, 75 });
        */
        /*        [TestMethod()]
                [DataRow(78,0)]
                //[DataRow(12, 1)]
                //[DataRow(25, 1)]
                //[DataRow(15, 0)]
                //[DataRow(24, 0)]
                public void RankTopVotedCandidateQTest(int input, int expected)
                {
                    Assert.AreEqual(expected, rankTop.Q(input));
                }
            }*/
    }
}

/*
[0, 1, 1, 0, 0, 1, 0], votes
[0, 5, 10, 15, 20, 25, 30] times

step1
get max index of vote sub array
find the first time greater than query time n, then return n-1 index

step2
sort candidates by votes
sort by count of votes then by most recent

0, 1, 1, 0

 */
