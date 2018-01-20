using System;

namespace OutVariables
{
    class Program
    {
        public void Run()
        {
            GetTime(out int hour);
            Console.WriteLine(hour);
            int i = 10;
        }
        
        public void GetTime(out int hour)
        {
            hour = 3;
            if(hour is int i)
            {

            }
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            n.Run();
        }
    }
}
