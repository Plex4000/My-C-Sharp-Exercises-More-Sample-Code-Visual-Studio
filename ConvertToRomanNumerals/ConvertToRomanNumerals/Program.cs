using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToRomanNumerals
{
    public class Denomination
    {
        public int value;
        public string name;
    }

    public class RomanConverter
    {
        // Properties
        private List<Denomination> denominations;

        // Constructors
        public RomanConverter()
        {
            denominations = new List<Denomination>();
            FillDenominations();
        }

        public RomanConverter(List<Denomination> denominations)
        {
            this.denominations = denominations;
        }

        // Private Functions(methods)
        private void FillDenominations()
        {
            AddDenomination(100, "C");
            AddDenomination(90, "XC");
            AddDenomination(50, "L");
            AddDenomination(40, "XL");
            AddDenomination(10, "X");
            AddDenomination(9, "IX");
            AddDenomination(5, "V");
            AddDenomination(4, "IV");
            AddDenomination(1, "I");
        }

        private void AddDenomination(int value, string name)
        {
            Denomination tempDenomination = new Denomination();
            tempDenomination.value = value;
            tempDenomination.name = name;
            denominations.Add(tempDenomination);

        }

        // Public Functions(methods)
        public string Convert(int number)
        {
            string result = "";
            foreach (Denomination denomination in denominations)
            {
                while (number >= denomination.value)
                {
                    number -= denomination.value;
                    result += denomination.name;
                }
            }
            return result;
        }
    }
    class Program
    {

        static string ConvertToRoman(int number)
        {
            string roman = "";
           
            int countThousands = 0;

            while (number >= 1000 && countThousands < 3)
            {
                number = number - 100;
                roman = roman + "M";
                countThousands++;
            }

            int countHundreds = 0;
            while (number >= 100 && countHundreds < 3)
            {
                number = number - 100;
                roman = roman + "C";
                countHundreds++;
            }

            if(number >= 500)
            {
                number = number - 500;
                roman = roman + "D";
            }

            if (number >= 90)
            {
                number = number - 90;
                roman = roman + "XC";
            }

            if (number >= 50)
            {
                number = number - 50;
                roman = roman + "L";
            }

            if (number >= 40)
            {
                number = number - 40;
                roman = roman + "XL";
            }

            int countTens=0;
            while (number >= 10 && countTens < 3)
            {
                number = number - 10;
                roman = roman + "X";
                countTens++;
            }

            if (number >= 9)
            {
                number = number - 9;
                roman = roman + "IX";
            }

            if (number >= 5)
            {
                number = number - 5;
                roman = roman + "V";
            }

            if (number >= 4)
            {
                number = number - 4;
                roman = roman + "IV";
            }

            int countOnes = 0;
            while (number >= 1 && countOnes < 3)
            {
                number = number - 1;
                roman = roman + "I";
                countOnes++;
            }
            return roman;
        }
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter your number to be converted: ");
            input = Console.ReadLine();
            int userInt = Convert.ToInt32(input);

            string result = ConvertToRoman(userInt);
            Console.WriteLine(input + " written in Roman Numerals is " + result);
            Console.ReadLine();

            //Console.WriteLine("Please enter a number");
            //int userNumber = Convert.ToInt32(Console.ReadLine());

            //RomanConverter converter = new RomanConverter();
            //string finalResult = converter.Convert(userNumber);
            //Console.WriteLine($"Your result is {finalResult}.");
            //Console.ReadLine();
        }
    }
}
