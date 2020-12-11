using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiophantineEquation;

namespace DiophantineEquation.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("[[3, 1]]", Kata.solEquaStr(5));
        }
        
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("[[4, 1]]", Kata.solEquaStr(12));
        }
        
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("[[7, 3]]", Kata.solEquaStr(13));
        }
        
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("[[4, 0]]", Kata.solEquaStr(16));
        }
        
        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("[[45003, 22501], [9003, 4499], [981, 467], [309, 37]]", Kata.solEquaStr(90005));
        }
    }
}
