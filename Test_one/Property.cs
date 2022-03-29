//属性

namespace runoob
{
    //实例
    class Student
    {
        private string code = "N.A";
        private string name = "Not know";
        private int age = 0;

        //声明string的Code属性
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        
        //声明类型为string的Name属性
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        //声明类型为int的Age属性
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code=" + Code + ",Name=" + Name + ",Age=" + Age;
        }
    }

    class ExampleDemo
    {
        // public static void Main()
        // {
        //     Student s = new Student();
        //     s.Code = "001";
        //     s.Name = "Zara";
        //     s.Age = 9;
        //     Console.WriteLine("Student Info：{0}",s);
        //     s.Age += 1;
        //     Console.WriteLine("Student Info：{0}",s);
        //     Console.ReadKey();
        // }
    }
}


//抽象属性
namespace runoobs
{
    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }

    class Student
    // class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // public override int Age
        // {
        //     get
        //     {
        //         return age;
        //     }
        //     set
        //     {
        //         age = value;
        //     }
        // }

        // public override string ToString()
        // {
        //     return "Code=" + code + ",Name=" + Name + ",Age=" + Age;
        // }
    }

    class ExampleDemo
    {
        // public static void Main()
        // {
        //     Student s = new Student();
        //     s.Code = "001";
        //     s.Name = "Zara";
        //     s.Age = 9;
        //     Console.WriteLine("Student Info：{0}", s);
        //     s.Age += 1;
        //     Console.WriteLine("Student Info：{0}", s);
        //     Console.ReadKey();
        // }
    }
}