// 委托
using System;
using System.IO;

//实例
// delegate int NumberChanger(int n);
//
// namespace DelegateAppp1
// {
//     class TestDelegate
//     {
//         private static int num = 10;
//
//         public static int AddNum(int p)
//         {
//             num += p;
//             return num;
//         }
//         
//         public static int MultNum(int q)
//         {
//             num *= q;
//             return num;
//         }
//
//         public static int getNum()
//         {
//             return num;
//         }

        // static void Main(string[] args)
        // {
            // NumberChanger nc1 = new NumberChanger(AddNum);
            // NumberChanger nc2 = new NumberChanger(MultNum);
            // nc1(25);
            // Console.WriteLine("Value of Num：{0}", getNum());
            // nc2(5);
            // Console.WriteLine("Value of Num：{0}", getNum());
            // Console.ReadKey();
            
            // NumberChanger nc;
            // NumberChanger nc1 = new NumberChanger(AddNum);
            // NumberChanger nc2 = new NumberChanger(MultNum);
            // nc=nc1;
            //
            // nc+=nc2;
            // nc(5);
            // Console.WriteLine("Value of Num：{0}", getNum());
            // Console.ReadKey();
        // }
    // }
// }

namespace DelegateAppp11
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void printString(string s);

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is：{0}", str);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("c:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void sendString(printString ps)
        {
            ps("Hello World");
        }

        // static void Main(string[] args)
        // {
        //     printString ps1 = new printString(WriteToScreen);
        //     printString ps2 = new printString(WriteToFile);
        //     sendString(ps1);
        //     sendString(ps2);
        //     Console.ReadKey();
        // }
    }
}