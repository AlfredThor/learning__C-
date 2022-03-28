/*多态*/

/*
 多态是同一个行为具有多个不同表现形式或形态的能力。
多态性意味着有多重形式。在面向对象编程范式中，多态性往往表现为"一个接口，多个功能"。
多态性可以是静态的或动态的。在静态多态性中，函数的响应是在编译时发生的。在动态多态性中，函数的响应是在运行时发生的。
在 C# 中，每个类型都是多态的，因为包括用户定义类型在内的所有类型都继承自 Object。
 */
 
 using System;
 using System.Data;
 using System.Collections.Generic;

namespace Polymorphic
{ 
    //静态多态性
   public class Polymorphics
   {
       public int Add(int a, int b, int c)
       {
           return a + b + c;
       }
   
       public int Add(int a, int b)
       {
           return a + b;
       }
   
       void print(int i)
       {
           Console.WriteLine("输出整型：{0}",i);
       }
   
       void print(double f)
       {
           Console.WriteLine("输出浮点型：{0}",f);
       }
   
       void print(string s)
       {
           Console.WriteLine("输出字符串：{0}",s);
       }

       // static void Main(string[] args)
       // {
       //     Polymorphics p = new Polymorphics();
       //     p.print(1);
       //     p.print(1.3);
       //     p.print("Hello World");
       //     Console.ReadKey();
       // }
   }

   class Progtam
   {
       // static void Main(string[] args)
       // {
       //     Polymorphics dataClass = new Polymorphics();
       //     int add1 = dataClass.Add(1, 2);
       //     int add2 = dataClass.Add(1, 2,3);
       //     
       //     Console.WriteLine("add1:",+add1);
       //     Console.WriteLine("add2:",+add2);
       // }
   }
}

//动态多态性

/*
 C# 允许您使用关键字 abstract 创建抽象类，用于提供接口的部分类的实现。当一个派生类继承自该抽象类时，实现即完成。抽象类包含抽象方法，抽象方法可
 被派生类实现。派生类具有更专业的功能。
请注意，下面是有关抽象类的一些规则：
    您不能创建一个抽象类的实例。
    您不能在一个抽象类外部声明一个抽象方法。
    通过在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。
 */

namespace PolymorphismApplication
{
    abstract class Shape
    {
        abstract public int area();
    }
    
    class Rectangle : Shape
    {
        private int lenght;
        private int width;
    
        public Rectangle(int a = 0, int b = 0)
        {
            lenght = a;
            width = b;
        }
    
        public override int area()
        {
            Console.WriteLine("Rectangle类的面试：");
            return (width * lenght);
        }
    }
    //
    // class RectangleTester
    // {
        // static void Main(string[] args)
        // {
        //     Rectangle r = new Rectangle(10,7);
        //     double a = r.area();
        //     Console.WriteLine("面积：{0}",a);
        //     Console.ReadKey();
        // }
    // }
}

namespace Mynamespaces
{

    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("执行基类的画圆任务");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个圆行");
            base.Draw();
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个长方形");
            base.Draw();
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个三角形");
            base.Draw();
        }
    }

    class Program
    {
        // static void Main(string[] args)
        // {
        //     var shapes = new List<Shape>
        //     {
        //         new Rectangle(),
        //         new Triangle(),
        //         new Circle(),
        //     };
        //     foreach (var shape in shapes)
        //     {
        //         shape.Draw();
        //     }
        //     Console.WriteLine("按下任意键退出。");
        //     Console.ReadKey();
        // }
    }
}

namespace Application
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int area()
        {
            Console.WriteLine("父类的面积：");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {
        }

        public override int area()
        {
            Console.WriteLine("Rectangle类的面积：");
            return (width * height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a=0,int b=0):base(a,b){}

        public override int area()
        {
            Console.WriteLine("Triangle类的面积：");
            return (width * height/2);
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("面积：{0}",a);
        }
    }

    class Tester
    {
        // static void Main(string[] args)
        // {
        //     Caller c = new Caller();
        //     Rectangle r = new Rectangle(10, 7);
        //     Triangle t = new Triangle(10, 5);
        //     c.CallArea(r);
        //     c.CallArea(t);
        //     Console.ReadKey();
        // }
    }
}