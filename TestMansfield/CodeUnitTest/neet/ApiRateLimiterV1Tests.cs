using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibrary1.Tests
{
/*    [TestClass()]
    public class ApiRateLimiterV1Tests
    {
        [TestMethod()]
        public void RateLimitTest()
        {
            // 1 request per 5 secs for a customer.
            var limiter = new ApiRateLimiterV1();
            var output = new List<bool>();
            
            
            output.Add(limiter.RateLimit(1));//0 true
            Thread.Sleep(TimeSpan.FromSeconds(1));
            output.Add(limiter.RateLimit(1));//1 false
            Thread.Sleep(TimeSpan.FromSeconds(1));
            output.Add(limiter.RateLimit(1));//2 false
            Thread.Sleep(TimeSpan.FromSeconds(4));
            output.Add(limiter.RateLimit(1));//6 true

            bool[] expected = { true, false, false, true };


            CollectionAssert.AreEquivalent(expected, output);
        }
    }*/
}