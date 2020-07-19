using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    class Solution
    {
        public char[] MyCreateArr(string inputText)
        {
            char[] outputTextArr = { };
            for (int i = 0; i < inputText.Length-1; i++)
            {
                Console.WriteLine("Hello");
                //outputTextArr[i] = inputText.
            }
            
            return outputTextArr;
        }

        public char[] CreateArr(string inputText)
        {
            char[] outputTextArr;
            outputTextArr = inputText.ToCharArray();
            return outputTextArr;
        }

        public void ReverseString(char[] s)
        {
            char temp;
            int j=s.Length-1;
            int midleWord = (s.Length) / 2;
            for (int i = 0; i < midleWord; i++)
            {
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                j--;
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
