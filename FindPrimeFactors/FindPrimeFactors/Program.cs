using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + ":");


            /*
                   Your logic goes here
                */
            string primes = "";
           
            if (n > 3)
            {
                for (int i = 2; i < n; i++)
                {
                        if (n % i == 0)
                        {
                        bool isPrime = true;
                            for (int j = 2; j < i; j++)
                            {
                                    if (i % j == 0)
                                    {
                                        isPrime = false;
                                        break;
                                    }
       
                            }

                            if (isPrime)
                            {
                                primes += " " + i;
                            }
                        }
                }
            }

            //if (n > 3)
            //{
            //    for (int i = n; i >= 2; i--)
            //    {
            //        if(i != n)
            //        {
            //            if (n % i == 0)
            //            {
            //                bool isPrime = true;
            //                for (int j = i; j >= 2; j--)
            //                {

            //                    if (j != i)
            //                    {

            //                       if(i % j == 0)
            //                        {
            //                            isPrime = false;
            //                            break;
            //                        }
            //                    }


            //                }

            //                if (isPrime)
            //                {
            //                    primes += " " + i;
            //                }
            //            }

            //        }



            //    }
            //}

            if (primes != "")
            Console.WriteLine("Prime Factors are: " + primes);
            else Console.WriteLine("There are no prime factors for your number.");
        }
    }
}
