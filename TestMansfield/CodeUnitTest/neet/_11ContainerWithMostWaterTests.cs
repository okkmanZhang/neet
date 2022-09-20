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
    public class _11ContainerWithMostWaterTests
    {
/*        [TestMethod()]
*//*        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 },49)]
        [DataRow(new int[] { 1, 1 },1)]*//*
        [DataRow(new int[] { 2, 3, 10, 5, 7, 8, 9 },36)]
        public void MaxAreaTest(int[] input, int expected)
        {
            Assert.AreEqual(expected, new _11ContainerWithMostWater().MaxArea(input));
        }*/
        /*
         *  i  j
            1, 8, 6, 2, 5, 4, 8, 3, 7
        area = (|input[j] - input[i]|)* (|j-i|)

         */
    }
}