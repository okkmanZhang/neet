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
    public class _90SbusetsTests
    {
/*        [TestMethod()]
        public void SubsetsTest()
        {
            new _78Subsets().Subsets(new int[] { 1, 2, 3 });
        }
*/    

        [TestMethod()]
        public void SbusetsTest()
        {
            var result = new _90Sbusets().SubsetsWithDup(new int[]{1,2,2});

            Console.WriteLine();
            int i =1;
            foreach(var x in result)
            {
                Console.Write($"{i}: ");
                Console.WriteLine(string.Join("", x));                
                i++;
            }
        }
}
}