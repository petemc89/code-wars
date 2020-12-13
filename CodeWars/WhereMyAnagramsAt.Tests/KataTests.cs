using NUnit.Framework;
using System.Collections.Generic;

namespace WhereMyAnagramsAt.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<string> { "a" }, Kata.Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Kata.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }
    }
}