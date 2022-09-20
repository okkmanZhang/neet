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
    public class _33SearchInRotatedSortedArrayTests
    {
/*        [TestMethod()]
        *//*[DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]*//*
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1 }, 0, 4)]
        [DataRow(new int[] { 7, 0, 1, 4, 5, 6 }, 0, 1)]
        [DataRow(new int[] { 0, 1, 4, 5, 6, 7 }, 0, 0)]
        [DataRow(new int[] { 4, 5, 7, 0, 1 }, 0, 3)]
        *//*        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
                [DataRow(new int[] { 1 }, 0, -1)]*//*
        public void SearchTest(int[] input, int target, int expected)
        {
            Assert.AreEqual(expected, new _33SearchInRotatedSortedArray().Search(input, target));
        }*/

        /*
         0
         4, 5, 6, 7, 0, 1, 2 pivot = 3

         5, 6, 7, 0, 1, 2 , 4
         2, 4, 5, 6, 7, 0, 1

         0, 1, 2, 4, 5, 6, 7
         7, 0, 1, 2, 4, 5, 6
         1, 2, 4, 5, 6, 7, 0
            

         num[0] < num[n-1]

         if ( num[i] > num[n-1-i] ) //found pivot
            pivot = n-1-i

         if (i > n-1-i>
        

         */
    }
}