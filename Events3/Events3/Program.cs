
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events3
{
    class Program
    {
        public delegate void MyEvent();

        public static event MyEvent thisEvent;

        public static void TestEvent()
        {
            if(thisEvent != null)
            {
                thisEvent();
            }
        }
        static void Main(string[] args)
        {
            thisEvent += PrintIt;

            TestEvent();

        }

        private static void PrintIt()
        {
            Console.WriteLine("thomer");
        }
    }
}
