using NUnit.Framework;
using SplitStrings;

namespace SplitString.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, Kata.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, Kata.Solution("abcdef"));
        }
    }
}
