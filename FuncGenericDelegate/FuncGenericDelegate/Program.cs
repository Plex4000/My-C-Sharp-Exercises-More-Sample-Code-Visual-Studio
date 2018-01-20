using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncGenericDelegate
{
    class Program
    {
        //public delegate int Transformer(int x);
        class Test
        {
            static void Main()
            {
                int[] values = { 1, 2, 3 };
                Transform(values, Square);

            foreach (int i in values)
                    Console.Write(i + " "); // 1 4 9
            }
            static void Transform<T>(T[] values, Func<T, T> transformer)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = transformer(values[i]);
            }
            static int Square(int x) => x * x;
        }
    }
}
