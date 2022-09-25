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
    public class _47Permutations2Tests
    {

        [TestMethod()]
        public void Test()
        {
            var result = new _47Permutations2().PermuteUnique(new int[]{1,1,2});

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