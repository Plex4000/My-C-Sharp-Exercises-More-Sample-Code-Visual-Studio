using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotheRomanAraibicConverter
{
    class Program
    {
        public static string ConvertFromInteger(int integerNumber)
        {
            if (integerNumber < 1)
                return String.Empty;
            if (integerNumber > 3999)
                throw new ArgumentException("integerNumber. Should be less than 3999");

            const string romanSymbols = "IVXLCDM";
            var orderOfNumber = (int)Math.Truncate(Math.Log10(integerNumber));

            var currentNumber = integerNumber;
            var sbRomanNumber = new StringBuilder();

            for (var i = orderOfNumber; i >= 0; i--)
            {
                int j = i * 2;
                int devisor = GetCurrentDevisor(i);
                int valueOfCurrentPower = (int)Math.Truncate((double)(currentNumber / devisor));

                switch (valueOfCurrentPower)
                {
                    case 1:
                        sbRomanNumber.Append(romanSymbols[j]);
                        break;
                    case 2:
                        sbRomanNumber.Append(romanSymbols[j], 2);
                        break;
                    case 3:
                        sbRomanNumber.Append(romanSymbols[j], 3);
                        break;
                    case 4:
                        sbRomanNumber.Append(romanSymbols[j]);
                        sbRomanNumber.Append(romanSymbols[j + 1]);
                        break;
                    case 5:
                        sbRomanNumber.Append(romanSymbols[j + 1]);
                        break;
                    case 6:
                        sbRomanNumber.Append(romanSymbols[j + 1]);
                        sbRomanNumber.Append(romanSymbols[j]);
                        break;
                    case 7:
                        sbRomanNumber.Append(romanSymbols[j + 1]);
                        sbRomanNumber.Append(romanSymbols[j], 2);
                        break;
                    case 8:
                        sbRomanNumber.Append(romanSymbols[j + 1]);
                        sbRomanNumber.Append(romanSymbols[j], 3);
                        break;
                    case 9:
                        sbRomanNumber.Append(romanSymbols[j]);
                        sbRomanNumber.Append(romanSymbols[j + 2]);
                        break;
                }
                currentNumber -= valueOfCurrentPower * devisor;
            }
            return sbRomanNumber.ToString();
        }

        public static int ConvertToInteger(string romanNumber)
        {
            if (romanNumber == null)
                throw new ArgumentNullException("romanNumber");

            int resultInteger = 0;

            romanNumber = romanNumber.ToUpperInvariant();

            for (int i = 0; i < romanNumber.Length; i++)
            {
                switch (romanNumber[i])
                {
                    case 'I':
                        if (i < romanNumber.Length - 1
                            && romanNumber[i + 1] != 'I')
                            resultInteger--;
                        else resultInteger++;
                        break;
                    case 'V':
                        resultInteger += 5;
                        break;
                    case 'X':
                        if (i < romanNumber.Length - 1
                            && (romanNumber[i + 1] == 'L'
                            || romanNumber[i + 1] == 'C'))
                            resultInteger -= 10;
                        else resultInteger += 10;
                        break;
                    case 'L':
                        resultInteger += 50;
                        break;
                    case 'C':
                        if (i < romanNumber.Length - 1
                            && (romanNumber[i + 1] == 'D'
                            || romanNumber[i + 1] == 'M'))
                            resultInteger -= 100;
                        else
                            resultInteger += 100;
                        break;
                    case 'D':
                        resultInteger += 500;
                        break;
                    case 'M':
                        resultInteger += 1000;
                        break;
                    default:
                        throw new ArgumentException("Wrong Roman number format.");
                }
            }
            return resultInteger;
        }

        private static int GetCurrentDevisor(int i)
        {
            return (int)Math.Pow(10, i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.ConvertFromInteger(454)); 
            
        }
    }
}
