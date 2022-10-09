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
    public class _297SerializeAndDeserializeBinaryTreeTests
    {



        [TestMethod()]
        public void test()
        {
            TreeNode root = new TreeNode
            {
                val = 1,
                left = new TreeNode { val = 2, right = new TreeNode { val = 4 } },
                right = new TreeNode { val = 3 }
            };

            var t = new _297SerializeAndDeserializeBinaryTree();
            var ts = t.serialize(root);

            Console.WriteLine(ts);

            var tree = t.deserialize(ts);


        }


        [TestMethod]
        public void test2()
        {
            TreeNode root = new TreeNode
            {
                val = 1,
                left = new TreeNode { val = 2, right = new TreeNode { val = 4 } },
                right = new TreeNode { val = 3 }
            };

            var t = new _297SerializeAndDeserializeBinaryTree();
            var ts = t.serializePost(root);

            Console.WriteLine(ts);

            // var tree = t.deserialize(ts);
        }
    }
}