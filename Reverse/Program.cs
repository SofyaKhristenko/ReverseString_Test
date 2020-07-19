using System;


namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IsPalindrome palindrome = new IsPalindrome();
            palindrome.IsPalindrom(-1);
            palindrome.IsPalindrom(10);
            palindrome.IsPalindrom(1221);
            palindrome.IsPalindrom(12321);

            Console.ReadKey();
        }
    }
}
