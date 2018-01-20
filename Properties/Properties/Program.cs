using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        //Read-only property
        public int Age { get;}
       
        public string Name { get; set; }

        public Program()
        {
            this.Age = 45;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"My name is {Name} and I'm {Age} years old.");
        }
        static void Main(string[] args)
        {
            Program example = new Program();
            example.Name = "James";

            example.PrintInfo();

        }
    }
}
