using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxMinTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            double MaxTemp = 0.0, MinTemp = 0.0;

            //write your logic here

            Console.WriteLine("please enter numbers: ");

            string input = Console.ReadLine();

            string[] temps = input.Split(' ');

            double[] tempsFinal = new double[temps.Length];

            for (int i = 0; i < temps.Length; i++)
            {
                double tempF;
                Double.TryParse(temps[i], out tempF);

                tempsFinal[i] = tempF;

            }

            for (int i = 0; i < tempsFinal.Length; i++)
            {
                if (i == 0)
                {
                    //check for max temp
                    if (tempsFinal[0] > tempsFinal[1])
                    {
                        MaxTemp = tempsFinal[0];
                    }
                    else if(tempsFinal[0] < tempsFinal[1])
                    {
                        MaxTemp = tempsFinal[1];
                    }
                    else
                    {
                        MaxTemp = tempsFinal[0];
                    }
 
                    //check for min temp
                    if (tempsFinal[0] > tempsFinal[1])
                    {
                        MinTemp = tempsFinal[1];
                    }
                    else if(tempsFinal[0] < tempsFinal[1])
                    {
                        MinTemp = tempsFinal[0];
                    }
                    else
                    {
                        MinTemp = tempsFinal[0];
                    }

                }

                else
                {
                    if (tempsFinal[Array.IndexOf(tempsFinal, MaxTemp)] < tempsFinal[i])

                    {
                        MaxTemp = tempsFinal[i];
                    }

                    if (tempsFinal[Array.IndexOf(tempsFinal, MinTemp)] > tempsFinal[i])

                    {
                        MinTemp = tempsFinal[i];
                    }
                }
            }

            //end 

            Console.WriteLine("Maximum:");
            Console.WriteLine(MaxTemp);
            Console.WriteLine("Minimum:");
            Console.WriteLine(MinTemp);
        }
    }
}
