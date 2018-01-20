using System;

namespace Events2
{
    class Program
    {
        public static event EventHandler OnEquals3;

        public void Equals3(int x)
        {
            if(x == 3 && OnEquals3 != null)
            {
                OnEquals3(this, EventArgs.Empty);
            }
        }

        public static void Printit(object sender, EventArgs e)
        {
            Console.WriteLine("hello!");
        }
        static void Main(string[] args)
        {
            OnEquals3 += Printit;

            Program p = new Program();
            p.Equals3(3);
        }
    }
}
