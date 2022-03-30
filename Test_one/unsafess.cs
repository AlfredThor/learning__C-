// 不安全代码

/*
 * 当一个代码块使用 unsafe 修饰符标记时，C# 允许在函数中使用指针变量。不安全代码或非托管代码是指使用了指针变量的代码块。
 * 指针 是值为另一个变量的地址的变量，即，内存位置的直接地址。就像其他变量或常量，您必须在使用指针存储其他变量地址之前声明指针。
 */
 using System;

namespace UnsafeCodeApplication
{
    class Program
    {
        // static unsafe void Main(string[] args)
        // {
        //     int var = 20;
        //     int* p = &var;
        //     Console.WriteLine("Data is: {0}", var);
        //     Console.WriteLine("Address is: {0}", (int)p);
        //     Console.ReadKey();
        // }
    }
}