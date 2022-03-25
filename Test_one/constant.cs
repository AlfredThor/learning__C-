/*常量*/
using System;

namespace constant
{
    class SampleClass
    {
        /*
         常量是固定值，程序执行期间不会改变。
         常量可以是任何基本数据类型，比如整数常量、浮点常量、字符
         常量或者字符串常量，还有枚举常量。
         常量可以被当作常规的变量，只是它们的值在定义后不能被修改。
         */
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        // static void Main()
        // {
        //     SampleClass mC = new SampleClass(11, 22);
        //     Console.WriteLine("x
        // = {0}, y = {1}", mC.x, mC.y);
        //     Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);
        // }
    }
}