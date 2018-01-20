using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            do
            {
               Console.Write("Please enter a string: ");
               inputString = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(inputString));

            string[] words = inputString.Split(' ');

            string longestWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }

            Console.WriteLine(longestWord);

            //string longestWord = "";
            //int lWordCount = 0;
            //ArrayList longestWords = new ArrayList();
            //for (int i = 0; i < words.Length; i++)
            //{

            //    if (words[i].Length > longestWord.Length)
            //    {
            //        if (lWordCount > 1)

            //        {
            //            longestWord = words[i];
            //            longestWords.Add(longestWord);
            //            longestWords.RemoveRange(0, lWordCount);
            //            lWordCount--;

            //            // lWordCount = 0;
            //        }
            //        else if (lWordCount == 1)
            //        {
            //            longestWord = words[i];
            //            longestWords.Add(longestWord);
            //            longestWords.RemoveAt(0);

            //        }
            //        else
            //        {
            //            longestWord = words[i];
            //            longestWords.Add(longestWord);
            //            lWordCount++;
            //        }

            //       // longestWords.RemoveRange(0, lWordCount);
            //    }
            //    else if(words[i].Length == longestWord.Length)
            //    {
            //        longestWord = words[i];
            //        longestWords.Add(longestWord);
            //        lWordCount++;
            //    }


            //}

            //foreach (var item in longestWords)
            //{
            //    Console.WriteLine(item);

            //}





        }
    }
}
