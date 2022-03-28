//命名空间

/*
 命名空间的设计目的是提供一种让一组名称与其他名称分隔开的方式。在一个命名空间中声明的类的名称与另一个命名空间中声明的相同的类的名称不冲突。
我们举一个计算机系统中的例子，一个文件夹(目录)中可以包含多个文件夹，每个文件夹中不能有相同的文件名，但不同文件夹中的文件可以重名
 */
 
 using System;
 using first_space;
 using secound_space;

namespace first_space
{
    class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace secound_space
{
    class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}

class TestClass
{
    // static void Main(string[] args)
    // {
    //     first_space.namespace_c1 fc = new namespace_c1();
    //     secound_space.namespace_c1 sc = new secound_space.namespace_c1();
    //     fc.func();
    //     sc.func();
    //     Console.ReadKey();
    // }
}

namespace first_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space
{
    class efg
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}  
class TestClasss
{
    // static void Main(string[] args)
    // {
    //     abc fc = new abc();
    //     efg sc = new efg();
    //     fc.func();
    //     sc.func();
    //     Console.ReadKey();
    // }
}