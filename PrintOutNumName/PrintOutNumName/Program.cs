using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOutNumName
{
    class Program
    {
        

        public static string GetOnesNumberName(int num, string numString, string[] ones)
        {
            switch (num)
            {
                case 1: numString += " " + ones[0]; break;
                case 2: numString += " " + ones[1]; break;
                case 3: numString += " " + ones[2]; break;
                case 4: numString += " " + ones[3]; break;
                case 5: numString += " " + ones[4]; break;
                case 6: numString += " " + ones[5]; break;
                case 7: numString += " " + ones[6]; break;
                case 8: numString += " " + ones[7]; break;
                case 9: numString += " " + ones[8]; break;
                case 10: numString += " " + ones[9]; break;
                case 11: numString += " " + ones[10]; break;
                case 12: numString += " " + ones[11]; break;
                case 13: numString += " " + ones[12]; break;
                case 14: numString += " " + ones[13]; break;
                case 15: numString += " " + ones[14]; break;
                case 16: numString += " " + ones[15]; break;
                case 17: numString += " " + ones[16]; break;
                case 18: numString += " " + ones[17]; break;
                case 19: numString += " " + ones[18]; break;
            }
            return numString;
        }
        static void Main(string[] args)
        {

            string[] ones = { "one", "two", "three", "four", "five", "six", " seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
            string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            Console.WriteLine("Enter the Number:");
            //  int num=Console.Read();

            int num;
            Int32.TryParse(Console.ReadLine(), out num);



            Console.WriteLine("Entered number is:");

            /*write down your logic here
           */



            string numString = "";

            if(num >= 100 && num < 1000)
            {
                int count = 0;
                while(num >= 100)
                {
                    num -= 100;
                    count++;
                }

                numString = Program.GetOnesNumberName(count, numString, ones) + " hundred";
            }
            if (num >= 90 && num < 100)
            {
                numString += " " + tens[7];
                num -= 90;
            }

            if (num >= 80 && num < 90)
            {
                numString += " " + tens[6];
                num -= 80;
            }

            if (num >= 70 && num < 80)
            {
                numString += " " + tens[5];
                num -= 70;
            }

            if (num >= 60 && num < 70)
            {
                numString += " " + tens[4];
                num -= 60;
            }

            if (num >= 50 && num < 60)
            {
                numString += " " + tens[3];
                num -= 50;
            }

            if (num >= 40 && num < 50)
            {
                numString += " " + tens[2];
                num -= 40;
            }

            if (num >= 30 && num < 40)
            {
                numString += " " + tens[1];
                num -= 30;
            }

            if (num >= 20 && num < 30)
            {
                numString += " " + tens[0];
                num -= 20;
            }

            if (num >= 1 && num <= 19)
            {
                numString = Program.GetOnesNumberName(num, numString, ones);
            }
            Console.WriteLine(numString);
        }

    }
}

