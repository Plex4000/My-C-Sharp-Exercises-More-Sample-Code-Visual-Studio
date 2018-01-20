using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And_Or_Conditional_Operators
{

    class Program
    {
        public static bool GetWeatherConditions(bool windy, bool rainy, bool sunny)
        {
            return windy && (rainy || sunny);
        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetWeatherConditions(true, true, true)); //ouputs true
            Console.WriteLine(GetWeatherConditions(true, false, true)); //ouputs true
            Console.WriteLine(GetWeatherConditions(true, false, false)); //ouputs false
            Console.WriteLine(GetWeatherConditions(false, true, false)); //ouputs false

        }
    }
}
