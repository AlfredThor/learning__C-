//集合

using System;
using System.Collections;

//动态数组

/*
 *它代表了可被单独索引的对象的有序集合。
它基本上可以替代一个数组。但是，与数组不同的是，您可以使用索引在指定的位置添加和移除项目，动态数组会自动重新调整它的大小。它也允许在列表中进行动态内存分配、增加、搜索、排序各项。
 */
namespace CollectionApplication1
{
    class Program
    {
    //     static void Main(string[] args)
    //     {
    //         ArrayList al = new ArrayList();
    //         Console.WriteLine("Adding some numbers:");
    //         al.Add(45);
    //         al.Add(78);
    //         al.Add(33);
    //         al.Add(56);
    //         al.Add(12);
    //         al.Add(23);
    //         al.Add(9);
    //         
    //         Console.WriteLine("Capacity：{0}", al.Capacity);
    //         Console.WriteLine("Count：{0}", al.Count);
    //         
    //         Console.Write("Content：");
    //         foreach (int i in al)
    //         {
    //             Console.Write(i+"");
    //         }
    //         Console.WriteLine();
    //         Console.Write("Sorted Content：");
    //         al.Sort();
    //         foreach (int i in al)
    //         {
    //             Console.Write(i+"");
    //         }
    //         Console.WriteLine();
    //         Console.ReadKey();
    //     }
    }
}

//哈希表

/*
 * Hashtable 类代表了一系列基于键的哈希代码组织起来的键/值对。它使用键来访问集合中的元素。
当您使用键访问元素时，则使用哈希表，而且您可以识别一个有用的键值。哈希表中的每一项都有一个键/值对。键用于访问集合中的项目。
 */
namespace CollectionApplication2
{
    class Program
    {
    //     static void Main(string[] args)
    //     {
    //         Hashtable ht = new Hashtable();
    //         
    //         ht.Add("001", "Zara Ali");
    //         ht.Add("002", "Abida Rehman");
    //         ht.Add("003", "Joe Holzner");
    //         ht.Add("004", "Mausam Benazir Nur");
    //         ht.Add("005", "M. Amlan");
    //         ht.Add("006", "M. Arif");
    //         ht.Add("007", "Ritesh Saikia");
    //
    //         if (ht.ContainsValue("Nuba Ali"))
    //         {
    //             Console.WriteLine("This student name is already in the list");
    //         }
    //         else
    //         {
    //             ht.Add("008","Nuha Ali");
    //         }
    //
    //         ICollection key = ht.Keys;
    //
    //         foreach (string k in key)
    //         {
    //             Console.WriteLine(k+":"+ht[k]);
    //         }
    //
    //         Console.ReadKey();
    //     }
    }
}

//排序列表

/*
 *SortedList 类代表了一系列按照键来排序的键/值对，这些键值对可以通过键和索引来访问。
排序列表是数组和哈希表的组合。它包含一个可使用键或索引访问各项的列表。如果您使用索引访问各项，则它是一个动态数组（ArrayList），如果您使用键访问各项，则它是一个哈希表（Hashtable）。集合中的各项总是按键值排序。
 */

namespace CollectionApplication3
{
    class Program
    { 
        // static void Main(string[] args)
        // { 
        //     SortedList s1 = new SortedList();
        //     
        //     s1.Add("001","Zara Ali");
        //     s1.Add("002","Abide Rehman");
        //     s1.Add("003","Joe Holzner");
        //     s1.Add("004","Mausam Benazir Nur");
        //     s1.Add("005","M.Amlan");
        //     s1.Add("006","M.Arif");
        //     s1.Add("007","Ritest Saikia");
        //
        //     if (s1.ContainsValue("Nuha Ali"))
        //     {
        //         Console.WriteLine("This student name is already in the list");
        //     }
        //     else
        //     {
        //         s1.Add("008","Nuha Ali");
        //     }
        //
        //     ICollection key = s1.Keys;
        //
        //     foreach (string k in key)
        //     {
        //         Console.WriteLine(k+':'+s1[k]);
        //     }
        // }
    }
}

//堆栈

/*
 * 堆栈（Stack）代表了一个后进先出的对象集合。当您需要对各项进行后进先出的访问时，则使用堆栈。当您在列表中添加一项，称为推入元素，当您从列表中移除一项时，称为弹出元素。
 */

namespace CollectionApplication4
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Stack st = new Stack();
        //
        //     st.Push('A');
        //     st.Push('M');
        //     st.Push('G');
        //     st.Push('W');
        //    
        //     Console.WriteLine("Current stack: ");
        //     foreach (char c in st)
        //     {
        //         Console.Write(c + " ");
        //     }
        //     Console.WriteLine();
        //    
        //     st.Push('V');
        //     st.Push('H');
        //     Console.WriteLine("The next poppable value in stack: {0}",
        //         st.Peek());
        //     Console.WriteLine("Current stack: ");          
        //     foreach (char c in st)
        //     {
        //         Console.Write(c + " ");
        //     }
        //     Console.WriteLine();
        //
        //     Console.WriteLine("Removing values ");
        //     st.Pop();
        //     st.Pop();
        //     st.Pop();
        //    
        //     Console.WriteLine("Current stack: ");
        //     foreach (char c in st)
        //     {
        //         Console.Write(c + " ");
        //     }
        // }
    }
}

//队列

/*
 * 队列（Queue）代表了一个先进先出的对象集合。当您需要对各项进行先进先出的访问时，则使用队列。当您在列表中添加一项，称为入队，当您从列表中移除一项时，称为出队。
 */

namespace CollectionApplication5
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Queue q = new Queue();
        //
        //     q.Enqueue('A');
        //     q.Enqueue('M');
        //     q.Enqueue('G');
        //     q.Enqueue('W');
        //  
        //     Console.WriteLine("Current queue: ");
        //     foreach (char c in q)
        //         Console.Write(c + " ");
        //     Console.WriteLine();
        //     q.Enqueue('V');
        //     q.Enqueue('H');
        //     Console.WriteLine("Current queue: ");        
        //     foreach (char c in q)
        //         Console.Write(c + " ");
        //     Console.WriteLine();
        //     Console.WriteLine("Removing some values ");
        //     char ch = (char)q.Dequeue();
        //     Console.WriteLine("The removed value: {0}", ch);
        //     ch = (char)q.Dequeue();
        //     Console.WriteLine("The removed value: {0}", ch);
        //     Console.ReadKey();
        // }
    }
}

//点阵列
namespace CollectionApplication6
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     // 创建两个大小为 8 的点阵列
        //     BitArray ba1 = new BitArray(8);
        //     BitArray ba2 = new BitArray(8);
        //     byte[] a = { 60 };
        //     byte[] b = { 13 };
        //    
        //     // 把值 60 和 13 存储到点阵列中
        //     ba1 = new BitArray(a);
        //     ba2 = new BitArray(b);
        //
        //     // ba1 的内容
        //     Console.WriteLine("Bit array ba1: 60");
        //     for (int i = 0; i < ba1.Count; i++)
        //     {
        //         Console.Write("{0, -6} ", ba1[i]);
        //     }
        //     Console.WriteLine();
        //    
        //     // ba2 的内容
        //     Console.WriteLine("Bit array ba2: 13");
        //     for (int i = 0; i < ba2.Count; i++)
        //     {
        //         Console.Write("{0, -6} ", ba2[i]);
        //     }
        //     Console.WriteLine();
        //    
        //    
        //     BitArray ba3 = new BitArray(8);
        //     ba3 = ba1.And(ba2);
        //
        //     // ba3 的内容
        //     Console.WriteLine("Bit array ba3 after AND operation: 12");
        //     for (int i = 0; i < ba3.Count; i++)
        //     {
        //         Console.Write("{0, -6} ", ba3[i]);
        //     }
        //     Console.WriteLine();
        //
        //     ba3 = ba1.Or(ba2);
        //     // ba3 的内容
        //     Console.WriteLine("Bit array ba3 after OR operation: 61");
        //     for (int i = 0; i < ba3.Count; i++)
        //     {
        //         Console.Write("{0, -6} ", ba3[i]);
        //     }
        //     Console.WriteLine();
        //    
        //     Console.ReadKey();
        // }
    }
}