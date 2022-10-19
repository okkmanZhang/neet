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
    public class _435NonOverlappingIntervalsTests
    {



        [TestMethod()]
        public void test()
        {
            var t = new _435NonOverlappingIntervals();

            //var s = t.EraseOverlapIntervals(new int[][] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 3 } });
            var s2 = t.EraseOverlapIntervals(new int[][] { new[] { 1, 100 }, new[] { 11, 22 }, 
                new[] { 1, 11 }, new[] { 2, 12 } });



        }
    }
}