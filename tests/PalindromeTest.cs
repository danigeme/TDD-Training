using NUnit.Framework;
using System;
namespace CSharp.Training.Tests
{
    public class PalindromeTest
    {
        Palindrome Pali = new Palindrome();


        
        [TestCase("Taco Cat")]
        [TestCase("Madam Im Adam")]
        [TestCase("Allí si María avisa y así va a ir a mi silla")]
        public void TPalindrome(string s)
        {
            Assert.AreEqual(Pali.pal(s), true, "Incorrect");
        }

        [TestCase("Lorem Ipsum")]
        [TestCase("Dolor sit Amer")]
        [TestCase("Omar Roma Ramo Amor Mora")]
        public void FPalindrome(string s)
        {
            Assert.AreEqual(Pali.pal(s), false, "Incorrect");
        }


    }
}
