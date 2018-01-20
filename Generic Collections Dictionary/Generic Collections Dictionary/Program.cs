using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
