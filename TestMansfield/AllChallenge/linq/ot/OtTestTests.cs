/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllChallenge.ot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.ot.Tests
{
    [TestClass()]
    public class OtTestTests
    {
        [TestMethod()]
        //[DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        //[DataRow(new int[] { 0 }, 1)]
        [DataRow(new int[] { -1 }, 1)]

        public void solutionTest(int[] input, int expected)
        {
            Assert.AreEqual(expected, new OtTest().solution(input));
        }

        [TestMethod()]

        public void solutionTest2()
        {
            var input = Enumerable.Repeat(1, 100000);

            Assert.AreEqual(1, new OtTest().solution(input.ToArray()));
        }
    }
}*/