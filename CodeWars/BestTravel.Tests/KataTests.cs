using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BestTravel.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            int? n = Kata.ChooseBestSum(163, 3, ts);
            Assert.AreEqual(163, n);

            ts = new List<int> { 50 };
            n = Kata.ChooseBestSum(163, 3, ts);
            Assert.AreEqual(null, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = Kata.ChooseBestSum(230, 3, ts);
            Assert.AreEqual(228, n);
        }
    }
}
