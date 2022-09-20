using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllChallenge.at.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Test1.Tests
{

    /*

         [1:02 01] : 2, refill [1:02 02] : 2, 

        [1:02 01 001, 1:02 01 002, 1:02 01 003, 1:02 01 004, 1:02 02 001,]

        [user1, user1, user1, user1,user1]

     */
    [TestClass()]
    public class RateLimiterTests
    {
/*        [TestMethod()]
        public void AllowTest()
        {
            var startTime = DateTimeOffset.Now;

            long[] timestamps = new long[] {
                startTime.ToUnixTimeSeconds(),
                startTime.AddMilliseconds(1).ToUnixTimeSeconds(),
                startTime.AddMilliseconds(2).ToUnixTimeSeconds(),
                startTime.AddMilliseconds(3).ToUnixTimeSeconds(),
                startTime.AddSeconds(1).ToUnixTimeSeconds()
            };

            string[] users = new[]
            {
                "user1",
                "user1",
                "user1",
                "user1",
                "user1"
            };

            bool[] expected = new bool[] { true, true, false, false, true };

            var rateLimiter = new RateLimiter(2);

            for (int i = 0; i < timestamps.Length; i++)
            {
                Console.WriteLine(rateLimiter.Allow(timestamps[i], users[i]));
            }
        }*/
    }
}