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
    public class _40CombinationSum2Tests
    {

        [TestMethod()]
        public void CombinationSum2Test()
        {
            var result = new _40CombinationSum2().CombinationSum2(new int[]{10,1,2,7,6,1,5},8);

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