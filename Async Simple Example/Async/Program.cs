using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        public async void Print()
        {
            await SlowWork();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("AFTER AWAIT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }

        }

        private async Task SlowWork()
        {
            for(int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
           
        }

        static void Main(string[] args)
        {
        
            Program prog = new Program();
            prog.Print();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("MAIN THREAD!");
            }




        }
    }
}
