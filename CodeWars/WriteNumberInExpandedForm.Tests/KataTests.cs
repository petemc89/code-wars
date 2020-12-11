using Microsoft.VisualStudio.TestTools.UnitTesting;
using WriteNumberInExpandedForm;

namespace WriteNumberInExpandedForm.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual("10 + 2", Kata.ExpandedForm(12));
            Assert.AreEqual("40 + 2", Kata.ExpandedForm(42));
            Assert.AreEqual("70000 + 300 + 4", Kata.ExpandedForm(70304));
        }
    }
}
