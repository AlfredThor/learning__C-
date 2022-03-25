/*基本语法*/

using System;

namespace HelloWorldApplication;

public class Test_two
{
    class Rectangle
    {
        //成员变量
        double lenght;
        double width;

        public void Accptdetails()
        {
            lenght = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return lenght * width;
        }

        public void Diaplay()
        {
            Console.WriteLine("Lenght:{0}",lenght);
            Console.WriteLine("Width:{0}",width);
            Console.WriteLine("Area:{0}",GetArea());
        }
    }

    // class ExecuteRectangle
    // {
    //     static void Main(string[] args)
    //     {
    //         Rectangle r = new Rectangle();
    //         r.Accptdetails();
    //         r.Diaplay();
    //         Console.ReadLine();
    //     }
    // }
}