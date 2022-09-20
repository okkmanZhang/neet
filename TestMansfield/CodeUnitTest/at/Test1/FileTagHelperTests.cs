using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllChallenge.at.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Test1.Tests
{
    [TestClass()]
    public class FileTagHelperTests
    {
        /*
         
        file1: cat, dog
        file2: dog, frog
        file3: dog, cat    

        file1: 1
        file2: 2
        file3: 3

        cat dog frog
         
         */

/*        [TestMethod()]
        public void TopTagsTest()
        {
            (string filename, string[] tags)[] fileTags =
            {
                ("file1", new[]{"cat", "dog"}),
                ("file2", new[]{"dog", "frog"}),
                ("file3", new[]{"dog", "cat"}),
            };
            int[] fileSizes = new[] { 1, 2, 3 };

            string[] expected = new[] { "cat", "dog", "frog" };

            CollectionAssert.AreEquivalent(expected, new FileTagHelper().TopTags(fileTags, fileSizes));
        }*/
    }
}