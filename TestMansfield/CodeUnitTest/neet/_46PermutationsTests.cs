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
    public class _46PermutationsTests
    {
/*        [TestMethod()]
        public void PermuteTest()
        {

            var x = new _46Permutations().Permute(new [] {1,2});
        }*/


        [TestMethod()]
        public void PermuteTest1()
        {

            IList<IList<int>> expected = new List<IList<int>>() {
                new List<int> {1,2},
                new List<int> {2,1},
            }.ToArray();
            
            var x = new _46Permutations().BacktrackMain(new [] {1,2}).ToArray();

            foreach(var ix in x.Select(s => string.Join("", s)))
            {
                Console.WriteLine(ix);
            }

            CollectionAssert.AreEquivalent(expected.Select(s => string.Join("", s)).ToArray(), x.Select(s => string.Join("", s)).ToArray());
        }

        [TestMethod()]
        public void PermuteTest2()
        {

            IList<IList<int>> expected = new List<IList<int>>() {
                new List<int> {1,2,3},
                new List<int> {1,3,2},
                new List<int> {2,1,3},
                new List<int> {2,3,1},
                new List<int> {3,1,2},
                new List<int> {3,2,1},
            }.ToArray();
            
            var x = new _46Permutations().BacktrackMain(new [] {1,2,3}).ToArray();

            foreach(var ix in x.Select(s => string.Join("", s)))
            {
                Console.WriteLine(ix);
            }

            CollectionAssert.AreEquivalent(expected.Select(s => string.Join("", s)).ToArray(), x.Select(s => string.Join("", s)).ToArray());
        }
    }
}