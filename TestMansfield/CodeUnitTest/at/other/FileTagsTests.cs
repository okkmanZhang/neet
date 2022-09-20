//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using AllChallenge.at;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AllChallenge.at.Tests
//{
//    [TestClass()]
//    public class FileTagsTests
//    {
//        [TestMethod()]
//        public void GroupFileTagTest1()
//        {
//            string[] fileNames = { "file1", "file2", "file3" };
//            List<string[]> tags = new List<string[]>
//                                {
//                                    new[]{ "cat", "dog", "ant"},
//                                    new[]{ "dog", "frog"},
//                                    new[]{ "dog", "cat"}
//                                };
//            int[] sizes = { 1, 2, 3 };
//            string[] expected = { "dog", "cat", "frog", "ant" };
//            var fileTags = new FileTags();
//            CollectionAssert.AreEquivalent(expected,
//                fileTags.GroupFileTag(fileNames, tags, sizes).ToArray());
//        }

//        [TestMethod()]
//        public void GroupFileTagTest2()
//        {
//            string[] fileNames = { "file1", "file2", "file3" };
//            List<string[]> tags = new List<string[]>
//                                {
//                                    new[]{ "cat", "dog", "ant"},
//                                    new[]{ "dog", "ant"},
//                                    new[]{ "dog", "cat"}
//                                };
//            int[] sizes = { 1, 2, 3 };

//            /*
//                cat: (file1) 1 + (file2) 2 + (file3) + 3 = 6
//                dog: (file1) 1 + (file2) 2 + (file3) + 3 = 6
//                ant: (file1) 1 + (file2) 2 = 3
//             */
//            string[] expected = { "cat", "dog", "ant" };

//            var fileTags = new FileTags();
//            CollectionAssert.AreEquivalent(expected,
//                fileTags.GroupFileTag(fileNames, tags, sizes).ToArray());
//        }
//    }
//}