using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.Tests
{
    [TestClass()]
    public class _1152AnalyzeUserWebsiteVisitPatternTests
    {
/*        [TestMethod()]
        public void MostVisitedPatternTest()
        {
            string[] usernames = { "joe", "joe", "joe", "james", "james", "james", "james", "mary", "mary", "mary" };
            int[] timestamps = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] websites = { "home", "about", "career", "home", "cart", "maps", "home", "home", "about", "career" };

            var x = new _1152AnalyzeUserWebsiteVisitPattern().MostVisitedPattern(
                usernames, timestamps, websites);

            Assert.Fail();
        }*/

/*        [TestMethod()]
        public void MostVisitedPatternTest2()
        {
            string[] usernames = { "zkiikgv", "zkiikgv", "zkiikgv", "zkiikgv" };
            int[] timestamps = { 436363475, 710406388, 386655081, 797150921 };
            string[] websites = { "wnaaxbfhxp", "mryxsjc", "oz", "wlarkzzqht" };

            var x = new _1152AnalyzeUserWebsiteVisitPattern().MostVisitedPattern(
                usernames, timestamps, websites);

            Assert.Fail();
        }*/

    }
}

/*
 
possible patterns
	foreach user
		list all three website the user visited.
		

sort the list by score (how many users, then lex)
 
 
 
 
 
 
 */