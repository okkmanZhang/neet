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
    public class _51NQueensTests
    {
        [TestMethod()]
        public void Test1()
        {
            _51NQueens queens = new _51NQueens();

            var result = queens.SolveNQueens(4);

            Console.WriteLine();
            foreach(var x in result)
            {
                Console.WriteLine(string.Join("\r\n", x));
                Console.WriteLine("\r\n");
            }
        }


    }
}