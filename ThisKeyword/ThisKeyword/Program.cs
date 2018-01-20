using System;

namespace ThisKeyword

{
    class calc
    {
        public int Sum { get; set; } = 1;
        public calc()
        {
                
        }

        public int SetSum()
        {
            Sum += 1;
            return Sum;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            calc c = new calc();
            calc d = new calc();
            
            Console.WriteLine((c.SetSum()));
            Console.WriteLine((d.SetSum()));
        }
    }
}
