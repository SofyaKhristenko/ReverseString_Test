using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution solution = new Solution();
            char[] test = { 'A', ' ', 'm', 'a', 'n', ',' , ' ', 'a',' ', 'p', 'l', 'a', 'n', ',', ' ', 'a',
                ' ', 'c', 'a', 'n', 'a', 'l', ':', ' ', 'p', 'a', 'n', 'a', 'm', 'a' };

            solution.ReverseString(solution.CreateArr("hello"));
            solution.ReverseString(solution.CreateArr("Hier"));
            solution.ReverseString(test);

            //Console.WriteLine(solution.MyCreateArr("hello"));




            Console.ReadKey();
        }
    }
}
