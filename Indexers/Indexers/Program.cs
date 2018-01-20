using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class StringDataStore
    {
        private Dictionary<int, string> dict = new Dictionary<int, string>() { { 1, "home" }, { 2, "workplace" } };
        private string[] strArr = new string[4];

        public StringDataStore()
        {

        }

        public string this[int index, string aString]
        {
            get
            {
                return dict[index];
            }

            set
            {
                dict.Add(index, aString);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException();

                return strArr[index];
            }

            set
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                strArr[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (str.ToLower() == name.ToLower())
                        return str;
                }

                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            strStore[10, "monkey"] = "";

            //using the int indexer
            for (int i = 0; i < 4; i++)
                Console.WriteLine(strStore[i]);

            Console.WriteLine();

            //using the string indexer
            Console.WriteLine(strStore["one"]);
            Console.WriteLine(strStore["two"]);
            Console.WriteLine(strStore["Three"]);
            Console.WriteLine(strStore["FOUR"]);
            Console.WriteLine(strStore[1, ""]);
        }
    }
}
