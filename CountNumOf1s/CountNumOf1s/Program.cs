using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumOf1s
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please enter a number: ");

            string input = Console.ReadLine();
            int sum = 0;
            foreach (var item in input)
            {
                int j;
                Int32.TryParse(item.ToString(), out j);

                if(j == 1)
                {
                    sum++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
