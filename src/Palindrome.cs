
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



    public static class ExtensionMethodPalindrome
    {
        public static bool isPalindrome(this string word)
        {

            word = word.Replace(" ", String.Empty);
            word = word.ToLower();
            char[] replacement = { 'a', 'a', 'a', 'a', 'a', 'a', 'c', 'e', 'e', 'e', 'e', 'i', 'i', 'i', 'i', 'n', 'o', 'o', 'o', 'o', 'o', 'u', 'u', 'u', 'u', 'y', 'y' };
            char[] accents = { 'à', 'á', 'â', 'ã', 'ä', 'å', 'ç', 'é', 'è', 'ê', 'ë', 'ì', 'í', 'î', 'ï', 'ñ', 'ò', 'ó', 'ô', 'ö', 'õ', 'ù', 'ú', 'û', 'ü', 'ý', 'ÿ', };
            for (int i = 0; i < accents.Length; i++)
            {
                word = word.Replace(accents[i], replacement[i]);
            }
            string first = word.Substring(0, word.Length);
            char[] arrword = word.ToCharArray();
            Array.Reverse(arrword);
            string temp = new string(arrword);
            string second = temp.Substring(0, temp.Length);
            return first.Equals(second);
        }

    }

}
