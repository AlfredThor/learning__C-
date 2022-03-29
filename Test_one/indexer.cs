//缩引器
/*
 *索引器（Indexer） 允许一个对象可以像数组一样使用下标的方式来访问。
 *当您为类定义一个索引器时，该类的行为就会像一个 虚拟数组（virtual array） 一样。您可以使用数组访问运算符 [ ] 来访问该类的的成员。
 *索引器的行为的声明在某种程度上类似于属性（property）。就像属性（property），您可使用 get 和 set 访问器来定义索引器。但是，属性返回或设置一个特定的数据成员，而索引器返回或设置对象实例的一个特定值。换句话说，它把实例数据分为更小的部分，并索引每个部分，获取或设置每个部分。
 * 
 */
 
 using System;
 using IndexerApplication;

namespace IndexerApplication
{
    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++) 
                namelist[i] = "N.A";
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        // static void Main(string[] args)
        // {
        //     IndexedNames names = new IndexedNames();
        //     names[0] = "Zara";
        //     names[1] = "Riz";
        //     names[2] = "Nuha";
        //     names[3] = "Asif";
        //     names[4] = "Davinder";
        //     names[5] = "Sunil";
        //     names[6] = "Rubic";
        //     for (int i = 0; i < IndexedNames.size; i++)
        //     {
        //         Console.WriteLine(names[i]);
        //     }
        //
        //     Console.ReadKey();
        // }
    }
}

//重载缩引器
namespace IndexerApplication1
{
    class IndexdNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            { 
                namelist[i] = "N.A.";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index<size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }

                    index++;
                }

                return index;
            }
        }

        // static void Main(string[] args)
        // {
        //     IndexdNames names = new IndexdNames();
        //     names[0] = "Zara";
        //     names[1] = "Riz";
        //     names[2] = "Nuha";
        //     names[3] = "Asif";
        //     names[4] = "Davinder";
        //     names[5] = "Sunil";
        //     names[6] = "Rubic";
        //     for (int i = 0; i < IndexdNames.size; i++)
        //     {
        //         Console.WriteLine(names[i]);
        //     }
        //     Console.WriteLine(names["Nuba"]);
        //     Console.ReadKey();
        // }
    }
}