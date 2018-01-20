using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add("Test");
            myArrayList.Add(4);

            Console.WriteLine(myArrayList[0]);
            Console.WriteLine(myArrayList[1]);

          


        }
    }
}
