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
    public class _380InsertDeleteGetRandomTests{
    


        [TestMethod()]
        public void test()
        {
            RandomizedSet r = new RandomizedSet();
            var p1 = r.Insert(1);
            var p2 = r.Remove(2);
            var p3 = r.GetRandom();

        }
    }
}