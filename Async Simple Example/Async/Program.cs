using Nito.AsyncEx;
using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async void MainAsync(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            await new Program().Backup();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        public async Task Backup()
        {
            var backupStatus = await BackupAsync();
            await Task.Delay(5000); //simulate some work
            Console.WriteLine(backupStatus);
        }


        public async Task<string> BackupAsync()
        {
            return await Task.Run(() => "groovy");
        }
        //public static async Task Print()
        //{
        //    await SlowWork();
        //    //for (int i = 0; i < 100; i++)
        //    //{
        //    //    Console.WriteLine("AFTER AWAIT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        //    //}

        //}

        //private static async Task SlowWork()
        //{
        //    for(int i = 0; i < 10000; i++)
        //    {
        //        Console.Write(i);
        //    }

        //}

        static void Main(string[] args)
        {

            AsyncContext.Run(() => MainAsync(args));

            //Print();


            for (int i = 0; i < 10000; i++)
            {
                Console.Write("MAIN THREAD!");
            }

        }
    }
}
