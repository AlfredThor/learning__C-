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
        // public static void Main()
        // {
        //     EventTest e = new EventTest();
        //     subscribEvent v = new subscribEvent();
        //     e.ChangeNum += new EventTest.NumManipulationHandIer(v.printf);
        //     e.SetValue(7);
        //     e.SetValue(11);
        // }
    }
}

namespace BoilerEventApp1
{
    class Boiler
    {
        private int temp;
        private int pressure;

        public Boiler(int t, int p)
        {
            temp = t;
            pressure = p;
        }

        public int getTemp()
        {
            return temp;
        }

        public int getPressure()
        {
            return pressure;
        }
    }

    class DelegateBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);
        public event BoilerLogHandler BoilerEventLog;
        public void  LogProcess()
        {
            string remark = "O.K";
            Boiler b = new Boiler(100, 12);
            int t = b.getTemp();
            int p = b.getPressure();
            if (t > 15 || t < 80 || p < 12 || p > 15)
            {
                remark = "Need Maintenance";
            }

            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Tempatature"+t+"\nPressure:"+p);
            OnBoilerEventLog("\nMessage:"+remark);
        }

        protected void OnBoilerEventLog(string message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }
    }

    class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter sw;

        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }

        public void Logger(string info)
        {
            sw.WriteLine(info);
        }

        public void Close()
        {
            sw.Close();
            fs.Close();
        }
    }

    public class RecordBoilerInfo
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }

        // static void Main(string[] args)
        // {
        //     BoilerInfoLogger filelog = new BoilerInfoLogger("c:\\boiler.txt");
        //     DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
        //     boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
        //     boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);
        //     boilerEvent.LogProcess();
        //     Console.ReadLine();
        //     filelog.Close();
        // }
    }
}