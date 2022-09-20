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
    public class _29DivideTwoIntegersTests
    {
/*        [TestMethod()]
*//*        [DataRow(10,3,3)]
        [DataRow(7,-3,-2)]*//*
        [DataRow(-2147483648, 1, -2147483648)]
        public void DivideTest(int dividend, int divisor, int result)
        {
            Assert.AreEqual(result, new _29DivideTwoIntegers().Divide(dividend, divisor));
        }*/
    }
}