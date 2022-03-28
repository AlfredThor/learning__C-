//异常处理
using System;

//实例
namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result;

        DivNumbers()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / n9um2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught:{0}", e);
            }
            finally
            {
                Console.WriteLine("Result:{0}",result);
            }
        }

        // static void Main(string[] args)
        // {
        //     DivNumbers d = new DivNumbers();
        //     d.division(25,0);
        //     Console.ReadKey();
        // }
    }
}

//用户自定义异常
namespace Application1
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp
        }
    }
}