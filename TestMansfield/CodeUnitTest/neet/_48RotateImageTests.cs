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
    public class _48RotateImageTests
    {
        //[TestMethod()]
        //public void RotateTest()
        //{
        //    int[][] m = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

        //    new _48RotateImage().Rotate(m);
        //}

        /*
            1(00) 2(01) 3(02) // m[i,j] i+(0-n-1), j= n -1-0
            4(10) 5(11) 6(12)
            7(20) 8(21) 9(22)

            7(00) 4(01) 1(02) 
            8(10) 5(11) 2(12)
            9(20) 6(21) 3(22)

         */
    }
}