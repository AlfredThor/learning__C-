//泛型

/*
 * 泛型（Generic） 允许您延迟编写类或方法中的编程元素的数据类型的规范，直到实际在程序中使用它的时候。换句话说，泛型允许您编写一个可以与任何数据类型一起工作的类或方法。

您可以通过数据类型的替代参数编写类或方法的规范。当编译器遇到类的构造函数或方法的函数调用时，它会生成代码来处理指定的数据类型。
 */
 
 //例子
 using System;
 using System.Collections.Generic;

namespace GenericApplication
{
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }

    class Tester
    {
        // static void Main(string[] args)
        // {
        //     MyGenericArray<int> intArray = new MyGenericArray<int>(5);
        //     for (int c = 0; c < 5; c++)
        //     {
        //         intArray.setItem(c, c*5);
        //     }
        //
        //     for (int c = 0; c < 5; c++)
        //     {
        //         Console.Write(intArray.getItem(c)+" ");
        //     }
        //     Console.WriteLine();
        //     MyGenericArray<char> charArray = new MyGenericArray<char>(5);
        //     for (int c = 0; c < 5; c++)
        //     {
        //         charArray.setItem(c, (char)(c+97));
        //     }
        //
        //     for (int c = 0; c < 5; c++)
        //     {
        //         Console.Write(charArray.getItem(c)+" ");
        //     }
        //     Console.WriteLine();
        //     Console.ReadKey();
        // }
    }
}

//泛型的特性

/*
使用泛型是一种增强程序功能的技术，具体表现在以下几个方面：
它有助于您最大限度地重用代码、保护类型的安全以及提高性能。
您可以创建泛型集合类。.NET 框架类库在 System.Collections.Generic 命名空间中包含了一些新的泛型集合类。您可以使用这些泛型集合类来替代 System.Collections 中的集合类。
您可以创建自己的泛型接口、泛型类、泛型方法、泛型事件和泛型委托。
您可以对泛型类进行约束以访问特定数据类型的方法。
关于泛型数据类型中使用的类型的信息可在运行时通过使用反射获取。
 */

namespace GenericMethodApp1
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        // static void Main(string[] args)
        // {
        //     int a, b;
        //     char c, d;
        //     a = 10;
        //     b = 20;
        //     c = 'I';
        //     d = 'V';
        //     
        //     Console.WriteLine("Int values before calling swap: ");
        //     Console.WriteLine("a={0}, b={1}", a, b);
        //     Console.WriteLine("Char values before calling swap:");
        //     Console.WriteLine("c = {0}, d = {1}", c, d);
        //     
        //     Swap<int>(ref a, ref b);
        //     Swap<char>(ref c, ref d);
        //     
        //     Console.WriteLine("Int values after calling swap:");
        //     Console.WriteLine("a = {0}, b = {1}", a, b);
        //     Console.WriteLine("Char values after calling swap:");
        //     Console.WriteLine("c = {0}, d = {1}", c, d);
        //     Console.ReadKey();
        // }
    }
}

//泛型委托
delegate T NumberChanger<T>(T n);
namespace GenericMethodApp2
{
    class TestDelegete
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        
        public static int getNum()
        {
            return num;
        }

        // static void Main(string[] args)
        // {
        //     NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
        //     NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
        //     
        //     nc1(25);
        //     Console.WriteLine("Value of Num: {0}", getNum());
        //     nc2(5);
        //     Console.WriteLine("Value of Num: {0}", getNum());
        //     Console.ReadKey();
        // }
    }
}