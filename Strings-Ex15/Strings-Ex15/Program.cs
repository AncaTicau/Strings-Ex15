using System;

namespace Strings_Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "this is a string and this is another string.";
            Console.WriteLine(GetDollarSignString(givenString));
        }
        //Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
        public static string GetDollarSignString(string input)
        {
            string result;
            char firstChar = input[0];

            result = input.Substring(1);
            result = result.Replace(firstChar, '$');

            return firstChar + result;
        }
    }
}
