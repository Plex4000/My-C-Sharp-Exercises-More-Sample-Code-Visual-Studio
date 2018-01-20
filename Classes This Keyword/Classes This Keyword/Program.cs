using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_This_Keyword
{
    class Program
    {
        int age;
        public Program(int age)
        {
            this.age = age;
        }
        static void Main(string[] args)
        {
            Program example = new Program(43);

        }
    }
}
