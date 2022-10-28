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
    public class _452MinimumNumberOfArrowsToBurstBalloonsTests
    {



        [TestMethod()]
        public void test()
        {
            var t = new _452MinimumNumberOfArrowsToBurstBalloons();
            var s2 = t.FindMinArrowShots(new int[][] { 
                 new[] { -2147483646,-2147483645 }, 
                new[] { 2147483646,2147483647} });

            Console.WriteLine(s2);
        }
    }
}