using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are the odd numbers from 1 to 99");

            for (int i = 1; i <= 99; i++)
            {

                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
         
            }
        }
    }
}
