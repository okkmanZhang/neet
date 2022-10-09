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
    public class _652FindDuplicateSubtreesTests
    {



        [TestMethod()]
        public void test()
        {
            TreeNode root = new TreeNode
            {
                val = 1,
                left = new TreeNode { val = 2, left = new TreeNode { val = 4 } },
                right = new TreeNode
                {
                    val = 3,
                    right = new TreeNode { val = 4 },
                    left = new TreeNode
                    {
                        val = 2,
                        left = new TreeNode { val = 4 }
                    }
                }
            };

            var t = new _652FindDuplicateSubtrees();
            t.FindDuplicateSubtrees(root);
        }
    }
}