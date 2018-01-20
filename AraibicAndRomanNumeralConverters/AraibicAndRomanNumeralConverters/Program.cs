using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraibicAndRomanNumeralConverters
{
    class Program
    {
        static int arabic(string rom)//converts roman numerals to arabic
        {
            int res = 0;
            for (int i = 0; i < rom.Length; i++)
            {
                {
                    if (rom[i].Equals('i') || rom[i].Equals('I'))
                    {
                        if (i == rom.Length - 1)
                            ++res;
                        else if (rom[i + 1].Equals('i') || rom[i + 1].Equals('I'))
                            ++res;
                        else
                            --res;
                    }
                    if (rom[i].Equals('v') || rom[i].Equals('V'))
                    {
                        if (i == rom.Length - 1)
                            res += 5;
                        else if (rom[i + 1].Equals('i') || rom[i + 1].Equals('I') || rom[i + 1].Equals('v') || rom[i + 1].Equals('V'))
                            res += 5;
                        else
                            res -= 5;
                    }
                    if (rom[i].Equals('x') || rom[i].Equals('X'))
                    {
                        if (i == rom.Length - 1)
                            res += 10;
                        else if (rom[i + 1].Equals('i') || rom[i + 1].Equals('I') || rom[i + 1].Equals('v') || rom[i + 1].Equals('V') || rom[i + 1].Equals('x') || rom[i + 1].Equals('X'))
                            res += 10;
                        else
                            res -= 10;
                    }
                    if (rom[i].Equals('l') || rom[i].Equals('L'))
                    {
                        if (i == rom.Length - 1)
                            res += 50;
                        else if (rom[i + 1].Equals('i') || rom[i + 1].Equals('I') || rom[i + 1].Equals('v') || rom[i + 1].Equals('V') || rom[i + 1].Equals('x') || rom[i + 1].Equals('X') || rom[i + 1].Equals('l') || rom[i + 1].Equals('L'))
                            res += 50;
                        else
                            res -= 50;
                    }
                    if (rom[i].Equals('c') || rom[i].Equals('C'))
                    {
                        if (i == rom.Length - 1)
                            res += 100;
                        else if (rom[i + 1].Equals('i') || rom[i + 1].Equals('I') || rom[i + 1].Equals('v') || rom[i + 1].Equals('V') || rom[i + 1].Equals('x') || rom[i + 1].Equals('X') || rom[i + 1].Equals('l') || rom[i + 1].Equals('L') || rom[i + 1].Equals('c') || rom[i + 1].Equals('C'))
                            res += 100;
                        else
                            res -= 100;
                    }
                    if (rom[i].Equals('d') || rom[i].Equals('D'))
                    {
                        if (i == rom.Length - 1)
                            res += 500;
                        else if (rom[i + 1].Equals('i') || rom[i + 1].Equals('I') || rom[i + 1].Equals('v') || rom[i + 1].Equals('V') || rom[i + 1].Equals('x') || rom[i + 1].Equals('X') || rom[i + 1].Equals('l') || rom[i + 1].Equals('L') || rom[i + 1].Equals('c') || rom[i + 1].Equals('C') || rom[i + 1].Equals('d') || rom[i + 1].Equals('D'))
                            res += 500;
                        else
                            res -= 500;
                    }
                    if (rom[i].Equals('m') || rom[i].Equals('M'))
                    {
                        if (i == rom.Length - 1)
                            res += 1000;
                        else if (rom[i + 1].Equals('i') || rom[i + 1].Equals('I') || rom[i + 1].Equals('v') || rom[i + 1].Equals('V') || rom[i + 1].Equals('x') || rom[i + 1].Equals('X') || rom[i + 1].Equals('l') || rom[i + 1].Equals('L') || rom[i + 1].Equals('c') || rom[i + 1].Equals('C') || rom[i + 1].Equals('d') || rom[i + 1].Equals('D') || rom[i + 1].Equals('m') || rom[i + 1].Equals('M'))
                            res += 1000;
                        else
                            res -= 1000;
                    }
                }
            }
            return res;
        }
        static string roman(int arab)//converts arabic numerals to roman
        {
            string rom = "";
            while (arab != 0)
            {
                if (arab - 1000 >= 0)
                {
                    rom = rom.Insert(rom.Length, "M");
                    arab -= 1000;
                }
                else if (Math.Abs(arab - 900) <= 100 && arab > 799)
                {
                    rom = rom.Insert(rom.Length, "CM");
                    arab -= 900;
                }
                else if (arab - 500 >= 0)
                {
                    rom = rom.Insert(rom.Length, "D");
                    arab -= 500;
                }
                else if (Math.Abs(arab - 400) <= 100 && arab > 299)
                {
                    rom = rom.Insert(rom.Length, "CD");
                    arab -= 400;
                }
                else if (arab - 100 >= 0)
                {
                    rom = rom.Insert(rom.Length, "C");
                    arab -= 100;
                }
                else if (Math.Abs(arab - 90) <= 10 && arab > 79)
                {
                    rom = rom.Insert(rom.Length, "XC");
                    arab -= 90;
                }
                else if (arab - 50 >= 0)
                {
                    rom = rom.Insert(rom.Length, "L");
                    arab -= 50;
                }
                else if (Math.Abs(arab - 40) <= 10 && arab > 39)
                {
                    rom = rom.Insert(rom.Length, "XL");
                    arab -= 40;
                }
                else if (arab - 10 >= 0)
                {
                    rom = rom.Insert(rom.Length, "X");
                    arab -= 10;
                }
                else if (Math.Abs(arab - 9) <= 1 && arab != 8)
                {
                    rom = rom.Insert(rom.Length, "IX");
                    arab -= 9;
                }
                else if (arab - 5 >= 0)
                {
                    rom = rom.Insert(rom.Length, "V");
                    arab -= 5;
                }
                else if (Math.Abs(arab - 4) <= 1 && arab != 3)
                {
                    rom = rom.Insert(rom.Length, "IV");
                    arab -= 4;
                }
                else if (arab - 1 >= 0)
                {
                    rom = rom.Insert(rom.Length, "I");
                    arab -= 1;
                }
                //arab = 0;
            }
            return rom;
        }
        static void Main(string[] args)
        {
            bool y = true;
            Console.Write("input: ");
            string s = Console.ReadLine();
            Console.Write(s + "\noutput: ");
            for (int i = 0; i < 10; i++)
            {
                if (s.IndexOf(Convert.ToString(i)) != -1)//if ints are detected in the string it is put through the roman converter
                {
                    Console.WriteLine(roman(Convert.ToInt32(s)));
                    y = false;
                    break;
                }
            }
            if (y == true)//if no ints are detected in the string it is put through the arabic converter
            {
                Console.Write(arabic(s));
            }
        }
    }
}
