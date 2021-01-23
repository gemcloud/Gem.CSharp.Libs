using Algorithms;
using NUnit.Framework;

namespace NUnitTestAlgorithms
{
    public class StringPlaygroundTest
    {
        const string expectdString = "123fedcb";
        string testString = "bcdef321";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestReserveString()
        {
            var result = StringPlayground.ReserveString(testString);
            Assert.AreEqual(expectdString, result);
            //Assert.Pass();
        }

        [Test]
        public void TestReserveStringLoop()
        {
            var result = StringPlayground.ReserveStringLoop(testString);
            Assert.AreEqual(expectdString, result);
        }

    }
}
