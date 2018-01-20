using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Example of Identifier Naming Conventions in C#
/// Method parameters, local variables, and private fields should be in camel case.
/// All others should be in Pascal case, i.e. enums, structs, classes, interfaces, properties and public fields, and methods. 
/// </summary>
namespace NamingConventions
{
    enum MyEnum //enumeration is in Pascal case
    {
        monday, tuesday, wednesday, thursday, friday
    }
    class Program //class name is in Pascal case
    {
        private int bodyMassIndex; //private field is in camel case
        public int Age { get; set; } = 45; //initialized property; this is a new C# 6.0 feature

        public int GetAge(int passedInAge) //Method name is in Pascal Case.
        {
            int returnedAge = passedInAge; //the local variable returnedAge is in camel case.
            return returnedAge;
        }
        static void Main(string[] args)
        {

        }
    }
}
