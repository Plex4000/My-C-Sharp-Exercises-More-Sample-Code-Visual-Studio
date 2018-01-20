using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraibicToRomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
               Dictionary<int, string> _arabic2Roman = new Dictionary<int, string>
        {
            {1000,"M"},
            {900,"CM"},
            {500,"D"},
            {400,"CD"},
            {100,"C"},
            {90,"XC"},
            {50,"L"},
            {40,"XL"},
            {10,"X"},
            {9,"IX"},
            {5,"V"},
            {4,"IV"},
            {1 ,"I"}
        };

            Console.Write("please entere a number: ");
            int arabicNumeral;
            Int32.TryParse(Console.ReadLine(), out arabicNumeral) ;
        var romanNumeral = string.Empty;

            foreach (var arabicFigure in _arabic2Roman.Keys)
            {
                while (arabicNumeral >= arabicFigure)
                {
                    romanNumeral += _arabic2Roman[arabicFigure];
                    arabicNumeral -= arabicFigure;
                }
}
            Console.WriteLine(romanNumeral);
    }
    }
}
