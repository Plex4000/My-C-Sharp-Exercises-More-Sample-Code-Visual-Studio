using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events.Program;

namespace Events
{
    class EventSubscriber
    {
        private Program _eventExample = new Program();

        public EventSubscriber()
        {
            _eventExample.MyEvent += PrintName; 
        }

        public void PrintName()
        {
            Console.WriteLine("Hello. My name Mark.");
        }

        public void TriggerEvent()
        {
            _eventExample.TriggerEvent();
        }

    }
    class Program
    {
        public Program()
        {

        }
        public delegate void PrintInfo();

        public event PrintInfo MyEvent;

        public void TriggerEvent()
        {
            if(MyEvent != null)
            {
                MyEvent();
            }

        }

        static void Main(string[] args)
        {
            EventSubscriber mysub = new EventSubscriber();
            mysub.TriggerEvent();
        }
    }
}
