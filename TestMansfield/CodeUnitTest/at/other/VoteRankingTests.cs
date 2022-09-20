//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using AllChallenge.at.Test1;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AllChallenge.at.Tests
//{
//    [TestClass()]
//    public class VoteRankingTests
//    {
//        [TestMethod()]
//        public void RankTeamsEasyVersionTest1()
//        {
//            VoteRanking voteRanking = new VoteRanking();
//            string[] votes = { "A", "C", "B", "C", "B", "A" };

//            Assert.AreEqual("ABC", new VoteRanking().RankTeamsEasyVersion(votes));
//        }

//        [TestMethod()]
//        public void RankTeamsEasyVersionTest2()
//        {
//            VoteRanking voteRanking = new VoteRanking();
//            string[] votes = { "Z", "Z", "B", "Z", "B", "A" };

//            Assert.AreEqual("ZBA", new VoteRanking().RankTeamsEasyVersion(votes));
//        }

//        [TestMethod()]
//        public void RankTeamsHardVersionTest()
//        {
//            VoteRanking voteRanking = new VoteRanking();
//            string[] votes = { "ABC", "BCA", "CAB", "ACB" };

//            Assert.AreEqual("ACB", new VoteRanking().RankTeamsHardVersion(votes));
//        }
//    }
//}