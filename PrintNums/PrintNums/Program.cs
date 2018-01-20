using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNums
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please enter a number: ");

            int num1;
            Int32.TryParse(Console.ReadLine(), out num1);

            var count = 1;
            while(count <= 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(num1+" ");
                }

                Console.WriteLine();

                for (int i = 0; i < 4; i++)
                {
                    Console.Write(num1);
                }

                Console.WriteLine();
                count++;
            }
        }
    }
}
