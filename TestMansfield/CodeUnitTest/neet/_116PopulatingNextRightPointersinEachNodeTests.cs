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
    public class _116PopulatingNextRightPointersinEachNodeTests
    {
/*        [TestMethod()]
        public void ConnectTest()
        {

            Node root = new Node(1,
                                new Node(2, 
                                    new Node(4, null, null,null),
                                    new Node(5, null, null, null), 
                                    null),
                                new Node(3,
                                    new Node(6, null, null, null), 
                                    new Node(7, null, null,null),
                                    null),
                                null);

            var x = new _116PopulatingNextRightPointersinEachNode().Connect(root);
        }*/

        [TestMethod]
        public void Test()
        {
            
            
            
            
            Node root = new Node(1,
                                new Node(2, 
                                    new Node(4, null, null,null),
                                    new Node(5, null, null, null), 
                                    null),
                                new Node(3,
                                    new Node(6, null, null, null), 
                                    new Node(7, null, null,null),
                                    null),
                                null);

            var r = new _116PopulatingNextRightPointersinEachNode()
                .ConnectLevel(root);
        }
    }
}