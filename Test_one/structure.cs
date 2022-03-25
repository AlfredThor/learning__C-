/*结构体*/

using System;
using System.Text;

// namespace Structuree
// {
//     class Structure
//     {
//         //结构体
//         struct Books
//         {
//             public string title;
//             public string author;
//             public string subject;
//             public string book_id;
//         }
//
//         public class Test
//         {
//             public static void Main(string[] args)
//             {
//                 Books Book1;    //声明Book1，类型为Books
//                 Books Book2;    //声明Book2，类型为Books
//                 
//                 //Book1详述
//                 Book1.title = "C#";
//                 Book1.author = "Nuha Ali";
//                 Book1.subject = "C Programing Tutorial";
//                 Book1.book_id = "5452";
//                 
//                 //Book2详述
//                 Book2.title = "Telecom Billing";
//                 Book2.author = "Zara Ali";
//                 Book2.subject = "Telecom BIlling Tuorial";
//                 Book2.book_id = "521452";
//                 
//                 //输出Book1信息
//                 Console.WriteLine("Book1 title:{0}",Book1.title);
//                 Console.WriteLine("Book1 author:{0}",Book1.author);
//                 Console.WriteLine("Book1 subject:{0}",Book1.subject);
//                 Console.WriteLine("Book1 book_id:{0}",Book1.book_id);
//                 
//                 //输出Book2信息
//                 Console.WriteLine("Book2 title:{0}",Book2.title);
//                 Console.WriteLine("Book2 author:{0}",Book2.author);
//                 Console.WriteLine("Book2 subject:{0}",Book2.subject);
//                 Console.WriteLine("Book2 book_id:{0}",Book2.book_id);
//                 
//                 Console.ReadKey();
//             }
//         }
//     }
// }

// struct Books
// {
//     private string title;
//     private string author;
//     private string subject;
//     private string book_id;
//
//     public void setValues(string t, string a, string s, string id)
//     {
//         title = t;
//         author = a;
//         subject = s;
//         book_id = id;
//     }
//
//     public void display()
//     {
//         Console.WriteLine("title:{0}",title);
//         Console.WriteLine("author:{0}",author);
//         Console.WriteLine("subkect:{0}",subject);
//         Console.WriteLine("Book_id:{0}",book_id);
//     }
// };
//
// public class TestStructure
// {
//     public static void Main(string[] args)
//     {
//         Books Book1 = new Books();
//         Books Book2 = new Books();
//         
//         Book1.setValues(
//             "C Programming",
//             "Nuha Ali",
//             "C Programming Tutorial",
//             "526654"
//             );
//         Book2.setValues(
//             "Telecom Billing",
//             "Zara Ali",
//             "Telecom Billing Tutorial",
//             "52634"
//             );
//         
//         Book1.display();
//         
//         Book2.display();
//
//         Console.ReadKey();
//     }
// }