using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest__5LongestPalindromicSubstring
    {
/*        [TestMethod]
        [DataRow("babad", "aba")]
        [DataRow("cbbd", "bb")]
        [DataRow("a", "a")]
        [DataRow("bb", "bb")]
        [DataRow("ac", "a")]
        public void TestMethod1(string s, string result)
        {
            _5LongestPalindromicSubstring c1 = new _5LongestPalindromicSubstring();
            Assert.AreEqual(result, c1.LongestPalindrome(s));
        }*/

        /*
         b a b a d
       | |
         b a b a d
         |
         b a b a d
         | |
         b a b a d
       * |   | +bab
         b a b a d
         |     |
         b a b a d
         |       | *right = end
         b a b a d
           |     
         b a b a d
           | |
         b a b a d
           |   | +aba

         b a b a d
                 | end

         */

/*        [TestMethod]
        [DataRow("babad", false)]
        [DataRow("abad", false)]
        [DataRow("aba", true)]
        [DataRow("bb", true)]
        [DataRow("bbaabb", true)]
        public void TestMethod1_IsP(string s, bool result)
        {
            _5LongestPalindromicSubstring c1 = new _5LongestPalindromicSubstring();

            Assert.AreEqual(result, c1.IsPal(s));
        }*/
    }
}