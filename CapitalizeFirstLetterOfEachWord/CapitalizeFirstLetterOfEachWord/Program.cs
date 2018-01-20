using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeFirstLetterOfEachWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string str = Console.ReadLine();
            Console.WriteLine("String is:" + str);
            string reString = "";
            //write your logic here



            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                reString += words[i][0]  char.ToUpper();
            }

            //end 
            Console.WriteLine("Result string is:");
            Console.Write(reString);
        }
    }
}
