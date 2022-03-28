/*类*/

using System;
using System.ComponentModel;
using System.Security.AccessControl;

namespace Class_Demo
{
    //实例
    // class Box
    // {
    //     public double lenght;   //长
    //     public double breadth;  //宽
    //     public double height;   //高
    // }
    //
    // class Boxtester
    // {
    //     static void Main(string[] args)
    //     {
    //         Box Box1 = new Box();   //声明Box1，类型为Box
    //         Box Box2 = new Box();   //声明Box2，类型为Box
    //         double volume = 0.0;    //体积
    //         
    //         //Box1详述
    //         Box1.height = 5.0;
    //         Box1.lenght = 6.0;
    //         Box1.breadth = 7.0;
    //         
    //         //Box2详述
    //         Box2.height = 10.0;
    //         Box2.lenght = 10.0;
    //         Box2.breadth = 10.0;
    //         
    //         //Box1体积
    //         volume = Box1.height * Box1.lenght * Box1.breadth;
    //         Console.WriteLine("Box1的体积：{0}",volume);
    //         
    //         //Box2体积
    //         volume = Box2.height * Box2.lenght * Box2.breadth;
    //         Console.WriteLine("Box2的体积：{0}",volume);
    //         Console.ReadKey();
    //     }
    // }
    
    //成员函数和封装
    // class Box
    // {
    //     private double lenght;
    //     private double breadth;
    //     private double height;
    //
    //     public void setLenght(double len)
    //     {
    //         lenght = len;
    //     }
    //
    //     public void setBreadth(double bre)
    //     {
    //         breadth = bre;
    //     }
    //
    //     public void setHeight(double hei)
    //     {
    //         height = hei;
    //     }
    //
    //     public double getVolume()
    //     {
    //         return lenght * breadth * height;
    //     }
    // }
    //
    // class Boxtester
    // {
    //     static void Main(string[] args)
    //     {
    //         Box Box1 = new Box();
    //         Box Box2 = new Box();
    //         double volume;
    //         
    //         Box1.setLenght(6.0);
    //         Box1.setBreadth(7.0);
    //         Box1.setHeight(5.0);
    //         
    //         Box2.setLenght(12.0);
    //         Box2.setBreadth(13.0);
    //         Box2.setHeight(10.0);
    //
    //         volume = Box1.getVolume();
    //         Console.WriteLine("Box1的体积：{0}",volume);
    //
    //         volume = Box2.getVolume();
    //         Console.WriteLine("Box2的体积：{0}",volume);
    //
    //         Console.ReadKey();
    //     }
    // }
    
    //构造函数
    // class Line
    // {
    //     private double lenght;
    //
    //     public Line()
    //     {
    //         Console.WriteLine("对象已创建");
    //     }
    //
    //     public void setLenght(double len)
    //     {
    //         lenght = len;
    //     }
    //
    //     public double getLenght()
    //     {
    //         return lenght;
    //     }
    //
    //     static void Main(string[] args)
    //     {
    //         Line line = new Line();
    //         line.setLenght(6.0);
    //         Console.WriteLine("线条的长度： {0}", line.getLenght());
    //         Console.ReadKey();
    //     }
    // }
    
    //参数化构造函数
    // class Line
    // {
    //     private double lenght;
    //
    //     public Line(double len)
    //     {
    //         Console.WriteLine("对象已创建，lenght={0}",len);
    //         lenght = len;
    //     }
    //
    //     public void setLenght(double len)
    //     {
    //         lenght = len;
    //     }
    //
    //     public double getLenght()
    //     {
    //         return lenght;
    //     }
    //
    //     static void Main(string[] args)
    //     {
    //         Line line = new Line(10.0);
    //         Console.WriteLine("线条的长度：{0}",line.getLenght());
    //         
    //         line.setLenght(6.0);
    //         Console.WriteLine("线条的长度：{0}",line.getLenght());
    //         Console.ReadKey();
    //     }
    // }
    
    //析构函数
    // class Line
    // {
    //     private double lenght;
    //
    //     public Line()
    //     {
    //         Console.WriteLine("对象已创建");
    //     }
    //
    //     ~Line()
    //     {
    //         Console.WriteLine("对象已删除");
    //     }
    //
    //     public void serLenght(double len)
    //     {
    //         lenght = len;
    //     }
    //
    //     public double getLenght()
    //     {
    //         return lenght;
    //     }
    //
    //     static void Main(string[] args)
    //     {
    //         Line line = new Line();
    //         line.serLenght(6.0);
    //         Console.WriteLine("线条的长度：{0}",line.getLenght());
    //     }
    // }
    
    //类的静态成员
    // class StaticVar
    // {
    //     public static int num;
    //
    //     public void count()
    //     {
    //         num++;
    //     }
    //
    //     public int GetNum()
    //     {
    //         return num;
    //     }
    // }
    //
    // class StaticTester
    // {
    //     static void Main(string[] args)
    //     {
    //         StaticVar s1 = new StaticVar();
    //         StaticVar s2 = new StaticVar();
    //         s1.count();
    //         s1.count();
    //         s1.count();
    //         s2.count();
    //         s2.count();
    //         s2.count();
    //         Console.WriteLine("s1的变量num：{0}",s1.GetNum());
    //         Console.WriteLine("s2的变量num：{0}",s2.GetNum());
    //         Console.ReadKey();
    //     }
    // }
    
    //静态函数
    // class StaticVar
    // {
    //     public static int num;
    //
    //     public void count()
    //     {
    //         num++;
    //     }
    //
    //     public static int getNum()
    //     {
    //         return num;
    //     }
    // }
    //
    // class StaticTester
    // {
    //     static void Main(string[] args)
    //     {
    //         StaticVar s = new StaticVar();
    //         s.count();
    //         s.count();
    //         s.count();
    //         Console.WriteLine("变量num：{0}",StaticVar.getNum());
    //         Console.ReadKey();
    //     }
    // }
} 