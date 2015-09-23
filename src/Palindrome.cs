using NUnit.Framework;
using System;
namespace CSharp.Training
{
    public class Palindrome
    {
        public bool pal(string P)
        {
            if (P.isPalindrome())
            {
                Console.WriteLine(P + " is palindrome");
                return true;
            }
            else
            {
                Console.WriteLine(P + " is NOT palindrome");
                return false;
            }

        }
    }
}
