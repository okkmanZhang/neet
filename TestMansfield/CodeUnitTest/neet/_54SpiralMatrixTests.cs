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
    public class _54SpiralMatrixTests
    {
        //[TestMethod()]        
        //public void SpiralOrderTest1()
        //{
        //    int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        //    IList<int> expected = new List<int>() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

        //    CollectionAssert.AreEquivalent(expected.ToArray(), new _54SpiralMatrix().SpiralOrder(input).ToArray());
        //}

        //[TestMethod()]
        //public void SpiralOrderTest2()
        //{
        //    int[][] input = new int[][] { new int[] { 1, 2, 3,4 }, new int[] { 5, 6,7,8 }, new int[] { 9,10,11,12 } };
        //    IList<int> expected = new List<int>() { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

        //    CollectionAssert.AreEquivalent(expected.ToArray(), new _54SpiralMatrix().SpiralOrder(input).ToArray());
        //}


/*
    1  2  3   00,01,03(ij++, j=n-1), 6(03 i++j), 9 (i++j, i=m-1), 8(ij--), 7(ij--, j=0), 4(i--j, visited), 5(ij++, visited ij++ and i++j)
    4  5  6   
    7  8  9   
 
 */
    }
}