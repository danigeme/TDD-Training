using NUnit.Framework;

namespace CSharp.Training.Tests
{   
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz fiz = new FizzBuzz();
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void DivBy3(int n) {
            Assert.AreEqual(fiz.module(n),"Fizz","Incorrect");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void DivBy5(int n)
        {
            Assert.AreEqual(fiz.module(n), "Buzz", "Incorrect");
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void DivBy3and5(int n)
        {
            Assert.AreEqual(fiz.module(n), "FizzBuzz", "Incorrect");
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(8)]
        public void NotDiv(int n)
        {
            Assert.AreEqual(fiz.module(n), "Nope", "Incorrect");
        }


    
    }
}
