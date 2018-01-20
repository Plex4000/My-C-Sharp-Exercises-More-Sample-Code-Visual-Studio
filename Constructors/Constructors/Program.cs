using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public Program(int age)
        {
            this.Age = age;
        }

        //Constructor overloading
        public Program(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        //Constructor chaining
        public Program(int age, string name, int weight) : this(age, name)
        {
            this.Weight = weight;
        }
        static void Main(string[] args)
        {
            Program example = new Program(45, "James", 165);

        }
    }
}
