using NUnit.Framework;
namespace CSharp.Training.Tests
{
    [TestFixture]
    public class PerfectNumberTest
    {
        PerfectNumber num = new PerfectNumber();
        [TestCase(6)]
        [TestCase(28)]
        [TestCase(33550336)]
        public void isPerf(int n)
        {
            Assert.AreEqual(num.PerfN(n), true, "Incorrect");
        }

        [TestCase(7)]
        [TestCase(30)]
        [TestCase(500)]
        public void isNotPerf(int n)
        {
            Assert.AreEqual(num.PerfN(n), false, "Incorrect");
        }

    }
}
