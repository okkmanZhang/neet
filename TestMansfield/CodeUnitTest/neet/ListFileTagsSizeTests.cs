using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.Tests
{
    [TestClass()]
    public class ListFileTagsSizeTests
    {
/*        [TestMethod()]
        public void SortFileByTagAndSizeTest()
        {
            var input = new FileSample[] { new FileSample() { Name = "f1", Size = 1, Tag = "java" },
                new FileSample() { Name = "f2", Size = 2, Tag = "music" },
                new FileSample() { Name = "f3", Size = 4, Tag = "java" },
                new FileSample() { Name = "f4", Size = 10, Tag = "f1" },
                new FileSample() { Name = "f5", Size = 20, Tag = "java" },
                new FileSample() { Name = "f6", Size = 20, Tag = "java" },
            };

            //java: 1+4+20+20=45
            //f1: 10
            //music: 2
            //[jave,f1,music]
            string[] expected = { "java", "f1", "music" };

            CollectionAssert.AreEquivalent(expected, new ListFileTagsSize().SortFileByTagAndSize(input));
        }

        [TestMethod()]
        public void SortFileByTagAndSizeTest2()
        {
            var input = new FileSample[] { new FileSample() { Name = "f1", Size = 1, Tag = "uk" },
                new FileSample() { Name = "f2", Size = 2, Tag = "us" },
                new FileSample() { Name = "f3", Size = 4, Tag = "uk" },
                new FileSample() { Name = "f4", Size = 10, Tag = "uk" },
                new FileSample() { Name = "f5", Size = 20, Tag = "uk" },
                new FileSample() { Name = "f6", Size = 20, Tag = "ca" },
            };

            //uk: 1+4+10+20=35
            //us: 2
            //ca: 20
            //[uk,ca,us]
            string[] expected = { "uk", "ca", "us" };

            CollectionAssert.AreEquivalent(expected, new ListFileTagsSize().SortFileByTagAndSize(input));
        }*/
    }
}