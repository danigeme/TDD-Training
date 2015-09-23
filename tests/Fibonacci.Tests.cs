using NUnit.Framework;
using System;
namespace CSharp.Training.Tests
{
     [TestFixture]
    public class FibonacciTests
    {
        Fibonacci fibo = new Fibonacci();

        [TestCase(6)]
        public void Fib6(int n)
        {
            Assert.AreEqual(fibo.sequence(n), "0 1 1 2 3 5", "Incorrect");
        }

        [TestCase(10)]
        public void Fib10(int n)
        {
            Assert.AreEqual(fibo.sequence(n), "0 1 1 2 3 5 8 13 21 34", "Incorrect");
        }

        [TestCase(-6)]
        public void FibN6(int n)
        {
            Assert.AreEqual(fibo.Nsequence(n), "0 -1 -1 -2 -3 -5", "Incorrect");
        }

        [TestCase(-10)]
        public void FibN10(int n)
        {
            Assert.AreEqual(fibo.Nsequence(n), "0 -1 -1 -2 -3 -5 -8 -13 -21 -34", "Incorrect");
        }


   

        
       
    }
}
