using System;
using System.Collections.Generic;

namespace ExtensionMethods2
{
    public static class extmethods
    {
        public static string ExtensionMethod(this string x)
        {
            return x + " keep the doctor away!";
        }

        public static T First<T>(this IEnumerable<T> sequence)
        {
            foreach (T element in sequence)
                return element;
            throw new InvalidOperationException("No elements!");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string newString = "Apples".ExtensionMethod();

            Console.WriteLine(newString);

            var j = new int[] { 1, 2};
            Console.WriteLine("Seattle".First()); // S
        }
    }
}
