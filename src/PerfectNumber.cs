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

    public static class ExtensionMethodPerfectNumber
    {
        public static bool IsPerfect(this int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            return sum == num;
        }

    }




}
