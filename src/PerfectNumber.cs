using System;
namespace CSharp.Training
{
    public class PerfectNumber
    {
        public bool PerfN(int n)
        {
            if (n.IsPerfect())
            {
                Console.WriteLine(n + " is palindrome");
                return true;
            }
            else
            {
                Console.WriteLine(n + " is NOT palindrome");
                return false;
            }

        }
        
    }
}
