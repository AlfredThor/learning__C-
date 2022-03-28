/*继承*/

using System;

namespace Inherits
{
    //实例
    // class Shape
    // {
    //     public void setWidth(int w)
    //     {
    //         width = w;
    //     }
    //
    //     public void setHeight(int h)
    //     {
    //         height = h;
    //     }
    //
    //     protected int width;
    //     protected int height;
    // }
    //
    // //派生类
    // class Rectangle : Shape
    // {
    //     public int getArea()
    //     {
    //         return (width * height);
    //     }
    // }
    //
    // class RectangleTester
    // {
    //     static void Main(string[] args)
    //     {
    //         Rectangle Rect = new Rectangle();
    //
    //         Rect.setWidth(5);
    //         Rect.setHeight(7);
    //         
    //         Console.WriteLine("总面积：{0}",Rect.getArea());
    //         Console.ReadKey();
    //     }
    // }

    // 基类的初始化
    // class Rectangle
    // {
    //     protected double lenght;
    //     protected double width;
    //
    //     public Rectangle(double l, double w)
    //     {
    //         lenght = l;
    //         width = w;
    //     }
    //
    //     public double getArea()
    //     {
    //         return lenght * width;
    //     }
    //
    //     public void Display()
    //     {
    //         Console.WriteLine("长度：{0}",lenght);
    //         Console.WriteLine("宽度：{0}",width);
    //         Console.WriteLine("面积：{0}",getArea());
    //     }
    // }
    //
    // class Tabletop : Rectangle
    // {
    //     private double cost;
    //     public Tabletop(double l,double w):base(1,w){}
    //
    //     public double getCost()
    //     {
    //         double cost;
    //         cost = getArea() * 70;
    //         return cost;
    //     }
    //
    //     public void Display()
    //     {
    //         base.Display();
    //         Console.WriteLine("成本：{0}",getCost());
    //     }
    // }
    //
    // class ExecuteRectangle
    // {
    //     static void Main(string[] args)
    //     {
    //         Tabletop t = new Tabletop(4.5, 7.5);
    //         t.Display();
    //         Console.ReadLine();
    //     }
    // }

    //多重继承
    // class Shape
    // {
    //     public void setWidth(int w)
    //     {
    //         width = w;
    //     }
    //
    //     public void setHeight(int h)
    //     {
    //         height = h;
    //     }
    //
    //     protected int width;
    //     protected int height;
    // }
    //
    // //基类
    // public interface PainCost
    // {
    //     int getCost(int area);
    // }
    //
    // //派生类
    // class Rectangle : Shape, PainCost
    // {
    //     public int getArea()
    //     {
    //         return (width * height);
    //     }
    //
    //     public int getCost(int area)
    //     {
    //         return area * 70;
    //     }
    // }
    //
    // class RectangleTester
    // {
    //     static void Main(string[] args)
    //     {
    //         Rectangle Rect = new Rectangle();
    //         int area;
    //         Rect.setWidth(5);
    //         Rect.setHeight(7);
    //         area = Rect.getArea();
    //         
    //         Console.WriteLine("总面积：{0}",Rect.getArea());
    //         Console.WriteLine("油漆总成本：{0}",Rect.getCost(area));
    //         Console.ReadKey();
    //     }
    // }
}