//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using AllChallenge.at;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AllChallenge.at.Tests
//{
//    [TestClass()]
//    public class RateLimitTests
//    {
//        [TestMethod()]
//        public void AllowTest()
//        {
//            RateLimit rateLimit = new RateLimit(1, 2);
//            var startTime = DateTime.Now;

//            Assert.AreEqual(true, rateLimit.Allow(startTime, "user1"));
//            Assert.AreEqual(true, rateLimit.Allow(startTime.AddSeconds(2), "user1"));
//            Assert.AreEqual(false, rateLimit.Allow(startTime.AddSeconds(10), "user1"));
//            Assert.AreEqual(true, rateLimit.Allow(startTime.AddSeconds(61), "user1"));

//            Assert.AreEqual(true, rateLimit.Allow(startTime.AddSeconds(2), "user2"));
//            Assert.AreEqual(true, rateLimit.Allow(startTime.AddSeconds(4), "user2"));
//            Assert.AreEqual(false, rateLimit.Allow(startTime.AddSeconds(8), "user2")); ;
//        }
//    }
//}