/*方法*/

/*
Access Specifier：访问修饰符，这个决定了变量或方法对于另一个类的可见性
Return type：返回类型，一个方法可以返回一个值。返回来兴释放回返回的值得数据类型。
如果方法不返回任何值，则返回类型为void
Method name：方法名称，是一个唯一的标识符，且是大小写敏感的。它不能与类中声明
的其他标识符相同
Parameter list：参数列表，使用圆括号包括起来，该参数是用来传递和接受方法的数
据。参数列表是指方法的参数类型、顺序和数量。参数是可选的，也就是说一个方法可能
不包含参数。
Method body：方法主体，包含了完成任务所需的指令集。
 */

using System;

namespace Test_one
{
    class Functions
    {
        public int FindMax(int num1, int num2)
        {
            /* 局部变量声明 */
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        public void swap(int x, int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
        
        public void swaps(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        
        // static void Main(string[] args)
        // {
        //     /* 局部变量定义 */
        //     int a = 100;
        //     int b = 200;
        //     int ret;
        //     Functions f = new Functions();
        //     
        //     //调用 FindMax 方法
        //     ret = f.FindMax(a, b);
        //     Console.WriteLine("最大值是：{0}", ret);
        //     Console.WriteLine();
        // }
        
        //递归方法调用
        // public int factorial(int num)
        // {
        //     int result;
        //     if (num == 1)
        //     {
        //         return 1;
        //     }
        //     else
        //     {
        //         result = factorial(num - 1) * num;
        //         return result;
        //     }
        // }
        //
        // static void Main(string[] args)
        // {
        //     Functions f = new Functions();
        //
        //     Console.WriteLine("6的阶乘是：{0}", f.factorial(6));
        //     Console.WriteLine("7的阶乘是：{0}", f.factorial(7));
        //     Console.WriteLine("8的阶乘是：{0}", f.factorial(8));
        //     Console.ReadLine();
        // }

        // static void Main(string[] args)
        // {
        //     Functions f = new Functions();
        //     int a = 100;
        //     int b = 200;
        //     
        //     Console.WriteLine("在交换之前，a的值：{0}", a);
        //     Console.WriteLine("在交换之前，b的值：{0}", b);
        //     //调用函数来交换值，按值传递参数
        //     //f.swap(a, b);
        //     
        //     //调用函数来交换值,按引用传递参数
        //     f.swaps(ref a,ref b);
        //     
        //     Console.WriteLine("在交换之后，a的值：{0}", a);
        //     Console.WriteLine("在交换之后，a的值：{0}", a);
        //     Console.WriteLine();
        // }

        // static void Main(string[] args)
        // {
        //     Functions f = new Functions();
        //     int a = 100;
        //     Console.WriteLine("在方法调用之前，a的值：{0}", a);
        //     
        //     f.getValue(out a);
        //     Console.WriteLine("在方法调用之后，a的值：{0}", a);
        //     Console.ReadLine();
        // }
    }
    
    //从另一个类中调用
    // class Test
    // {
    //     static void Main(string[] args)
    //     {
    //         /* 局部变量定义 */
    //         int a = 100;
    //         int b = 200;
    //         int ret;
    //         Functions f = new Functions();
    //         
    //         //调用 FindMax 方法
    //         ret = f.FindMax(a, b);
    //         Console.WriteLine("最大值是：{0}", ret);
    //         Console.WriteLine();
    //     }
    // }
    
}