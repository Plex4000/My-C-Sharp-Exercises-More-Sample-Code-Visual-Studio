using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInstantiation
{  
    public interface ITest
    {
        void PrintName();
    }

    class Test : ITest
    {
        public void PrintName()
        {
            Console.WriteLine("hi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          //Itest test = new Itest(); //generates compile time error
        }
    }
}
