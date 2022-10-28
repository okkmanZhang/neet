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
    public class _1024VideoStitchingTests{
    


        [TestMethod()]
        public void test()
        {
            var s = new _1024VideoStitching().VideoStitching(
                new int[][]{
                    new int[]{0,2}, new int[]{4,6}, new int[]{8,10},new int[]{1,9},new int[]{1,5},new int[]{5,9}
                },
                10
            );
        }
    }
}