using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", "Four");

            int i = (int) sortedList["one"];
            int j = (int) sortedList["two"];
            string str = (string) sortedList["four"];

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(str);

            //Access sorted list values with foreach loop
            SortedList sortedList1 = new SortedList();
            sortedList1.Add("one", 1);
            sortedList1.Add("two", 2);
            sortedList1.Add("three", 3);
            sortedList1.Add("four", 4);

            //remove values
            sortedList1.Remove("one");//removes element whose key is 'one'
            sortedList1.RemoveAt(0);//removes element at zero index i.e first element: four

            foreach (DictionaryEntry kvp in sortedList1)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
