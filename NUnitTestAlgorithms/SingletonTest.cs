using Algorithms;
using NUnit.Framework;

namespace NUnitTestAlgorithms
{
    public class SingletonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSingleton_NotSafe()
        {
            string expectedResult = "not thread-safe";
            var result = Singleton.Instance.DoSomething(expectedResult);
            Assert.AreEqual(expectedResult, result);
        }
    }
}