using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace test
{
    partial class DynamicProgrammingTests : TestTemplate
    {

        [Test]
        [TestCase("foo", "bar")]
        public void _376_WiggleSubsequence(string arr, string expected)
        {
            var s = new _376_WiggleSubsequence.Solution();
            //int result = s.LengthOfLongestSubstring(arr);
            //Assert.AreEqual(expected, result);
            Assert.Pass();
        }
    }
}