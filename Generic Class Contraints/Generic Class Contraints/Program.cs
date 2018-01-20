using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Contraints
{
    class MyGenericClass<T> where T : class
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<string> strGenericClass = new MyGenericClass<string>("Hello World");
            strGenericClass.genericMethod("Hello Again!");
        }
    }
}
