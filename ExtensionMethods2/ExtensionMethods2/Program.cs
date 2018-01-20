using System;

namespace ExtensionMethods2
{
    public static class extmethods
    {
        public static string ExtensionMethod(this string x)
        {
            return x + " keep the doctor away!";
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string newString = "Apples".ExtensionMethod();

            Console.WriteLine(newString);
        }
    }
}
