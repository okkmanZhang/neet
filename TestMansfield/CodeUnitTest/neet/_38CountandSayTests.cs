using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class _38CountandSayTests
    {
/*        [TestMethod()]
        *//*[DataRow(1, "1")]*//*
        [DataRow(4, "1211")]
        public void CountAndSayTest(int input, string expected)
        {
            Assert.AreEqual(expected, new _38CountandSay().CountAndSay(input));
        }*/

        /*



         1
         1

        2
        one 1 = 11 [{1,1}]

        3
        two 1 = 21 [{1,2}, {1,1}]

        4
        one 2 one 1 = 1211 ([{1,1},{1,2},{2,1}])

        5
        one 1 one 2 two 1 = 111221

        covert f(n-1) = [{x,y},{x,y}] => string



         */
    }
}