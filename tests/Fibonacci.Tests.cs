using NUnit.Framework;
using System;
namespace CSharp.Training.Tests
{
     [TestFixture]
    public class FibonacciTests
    {
        Fibonacci fibo = new Fibonacci();

        [TestCase]
        public void Fib()
        {
            Assert.AreEqual(fibo.sequence(6), 5, "Incorrect");
            Assert.AreEqual(fibo.sequence(10), 34, "Incorrect");
        }

        [TestCase]
        public void FibN()
        {
            Assert.AreEqual(fibo.Nsequence(-6), -5, "Incorrect");
            Assert.AreEqual(fibo.Nsequence(-10), -34, "Incorrect");
        }

   
   

        
       
    }
}
