using System;

namespace SimpleEvent
{
    using System;

    public class EventTest
    {
        private int value;

        public delegate void NumManipulationHandIer();

        public event NumManipulationHandIer ChangeNum;

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("event not fire");
                Console.ReadKey();
            }
        }

        public EventTest()
        {
            int n = 5;
            SetValue(n);
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }

    public class subscribEvent
    {
        public void printf()
        {
            Console.WriteLine("event fire");
            Console.ReadKey();
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            EventTest e = new EventTest();
            subscribEvent v = new subscribEvent();
            e.ChangeNum += new EventTest.NumManipulationHandIer(v.printf);
            e.SetValue(7);
            e.SetValue(11);
        }
    }
}