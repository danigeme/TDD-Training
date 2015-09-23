using NUnit.Framework;
using System;
namespace CSharp.Training.Tests
{
     [TestFixture]
    public class LeapYear
    {
         [TestCase(1904)]
         [TestCase(1988)]
         [TestCase(2016)]
         public void LeapY(int n)
         {
             Assert.AreEqual(Leap(n), n +  " is a leap year", "Incorrect");
         }

         [TestCase(1903)]
         [TestCase(1987)]
         [TestCase(2015)]
         public void NLeapY(int n)
         {
             Assert.AreEqual(Leap(n), n + " is not a leap year", "Incorrect");
         }



         [Test]
         public string Leap(int year) {
             string msj = "";
            if (year % 4 == 0){
                if (year % 100 == 0){
                    if (year % 400 == 0){
                    msj=year + " is a leap year";                    
                    }             
                    else{msj=year + " is not a leap year";}              
                   }
                else { msj = year + " is a leap year"; }  
            }
            else { msj=year + " is not a leap year"; }
             return msj;
         }
    }
}
