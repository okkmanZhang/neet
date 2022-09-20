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
    public class Rank1Tests
    {
        //[TestMethod()]
        //public void RankTeams1Test()
        //{
        //    string[] i1 = { "A", "B", "B", "C", "B", "A", "B" };
        //    string e1 = "B";

        //    Assert.AreEqual(e1, new Rank1().RankTeams1(i1));
        //}

/*        [TestMethod()]
        [DataRow(new[] {"ABC", "ACB", "ABC", "ACB", "ACB"}, "ACB")]
        public void RankTeams1366Test(string[] input, string expected)
        {
            Assert.AreEqual(expected, new ZZRank1().RankTeams1366(input));
        }*/

        /*
          ["ABC","ACB","ABC","ACB","ACB"]
          
          A 0 0 0
          B 0 0 0
          C 0 0 0

          A 5 0 0
          B 0 2 3
          C 0 3 2

          then alpha.



         */
    }
}