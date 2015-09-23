using NUnit.Framework;
using System;
namespace CSharp.Training.Tests
{
     [TestFixture]
    public class LeapYearT
    {
         LeapYear time = new LeapYear();
       

         [TestCase(1904)]
         [TestCase(1988)]
         [TestCase(2016)]
         public void LeapY(int n)
         {
             Assert.AreEqual(time.Leaping(n), n +  " is a leap year", "Incorrect");
         }

         [TestCase(1903)]
         [TestCase(1987)]
         [TestCase(2015)]
         public void NLeapY(int n)
         {
             Assert.AreEqual(time.Leaping(n), n + " is not a leap year", "Incorrect");
         }

    }
}
