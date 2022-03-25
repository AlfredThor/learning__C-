/*封装*/
using System;
using System.Drawing;

/*
定义：把一个或多个项目封闭在一个物理或者逻辑的包中，防止对实现细节的访问
 封装根据具体的需要，设置使用者的访问权限，并通过访问修饰符来实现
 访问修饰符如下：
 public：所有对象都可以访问
 private：对象本身在对象内部可以访问
 protected：只有该类对象及其子类对象可以访问
 internal：同一个程序集的对象可以访问
 protected intemal：访问限于当前程序集或派生自包含类的类型
 */

namespace Test_one
{
    // class Packaging
    // {
    //     
    //     /*
    //      public
    //      成员变量 length 和 width 被声明为 public，所以它们可以被函数 Main() 使用 Rectangle 类的实例 r 访问。
    //      成员函数 Display() 和 GetArea() 可以直接访问这些变量。
    //      成员函数 Display() 也被声明为 public，所以它也能被 Main() 使用 Rectangle 类的实例 r 访问。
    //      */
    //     
    //     //成员变量
    //     public double lenght;
    //     public double width;
    //
    //     public double GetAree()
    //     {
    //         return lenght * width;
    //     }
    //
    //     public void Display()
    //     {
    //         Console.WriteLine("长度：{0}", lenght);
    //         Console.WriteLine("宽度：{0}", width);
    //         Console.WriteLine("面积：{0}", GetAree());
    //     }
    //
    //     class ExecutePackaging
    //     {
    //         static void Main(string[] args)
    //         {
    //             Packaging r = new Packaging();
    //             r.lenght = 4.5;
    //             r.width = 3.5;
    //             r.Display();
    //             Console.ReadLine();
    //         }
    //     }
    // }

    // class Rectangle
    // {
    //     /*
    //      Private 
    //      访问修饰符允许一个类将其成员变量和成员函数对其他的函数和对
    //      象进行隐藏。
    //      只有同一个类中的函数可以访问它的私有成员。
    //      即使是类的实例也不能访问它的私有成员。
    //      */
    //     private double lenght;
    //     private double width;
    //
    //     public void Acceptdetails()
    //     {
    //         Console.WriteLine("请输入长度：");
    //         lenght = Convert.ToDouble(Console.ReadLine());
    //         Console.WriteLine("请输入宽度：");
    //         width = Convert.ToDouble(Console.ReadLine());
    //     }
    //
    //     public double GetArea()
    //     {
    //         return lenght * width;
    //     }
    //
    //     public void Display()
    //     {
    //         Console.WriteLine("长度：{0}", lenght);
    //         Console.WriteLine("宽度：{0}", width);
    //         Console.WriteLine("面积：{0}", GetArea());
    //     }
    //
    //     class ExcuteRectangle
    //     {
    //         static void Main(string[] args)
    //         {
    //             Rectangle r = new Rectangle();
    //             r.Acceptdetails();
    //             r.Display();
    //             Console.ReadLine();
    //         }
    //     }
    // }
    // class Master
    // {
    //     /*
    //      Internal 访问说明符允许一个类将其成员变量和成员函数暴露给当前程
    //      序中的其他函数和对象。换句话说，带有 internal 访问修饰符的任何
    //      成员可以被定义在该成员所定义的应用程序内的任何类或方法访问。
    //      */
    //     internal double lenght;
    //     internal double width;
    //
    //     double GetArea()
    //     {
    //         return lenght * width;
    //     }
    //
    //     public void Display()
    //     {
    //         Console.WriteLine("长度：{0}", lenght);
    //         Console.WriteLine("宽度：{0}", width);
    //         Console.WriteLine("面积：{0}", GetArea());
    //     }
    //
    //     class ExecuteMaster
    //     {
    //         static void Main(string[] args)
    //         {
    //             Master r = new Master();
    //             r.lenght = 4.5;
    //             r.width = 3.5;
    //             r.Display();
    //             Console.ReadLine();
    //         }
    // }
    // }
}