using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace AllChallenge.Tests
{
    [TestClass()]
    public class _698PartitionKEqualSumSubsetsTests
    {
        [TestMethod()]      
        public void test()
        {
            var x = new _698PartitionKEqualSumSubsets()
                .CanPartitionKSubsets(new int[]{4,3,2,3,5,2,1}, 4);
        }
    }
}