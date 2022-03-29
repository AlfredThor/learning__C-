//特性

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using first_space;

public class Myclass
{
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }
}

class Test
{
    static void function1()
    {
        Myclass.Message("In Function 1.");
        function2();
    }

    static void function2()
    {
        Myclass.Message("In Function 2.");
    }

    // public static void Main()
    // {
    //     Myclass.Message("In Main function.");
    //     function1();
    //     Console.ReadKey();
    // }
}

namespace Testsss
{
    [
        AttributeUsage(AttributeTargets.Class |
                       AttributeTargets.Constructor |
                       AttributeTargets.Field |
                       AttributeTargets.Method |
                       AttributeTargets.Property,
            AllowMultiple = true)
    ]
    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;
        
        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}