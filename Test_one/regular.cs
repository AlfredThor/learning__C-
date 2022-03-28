//正则表达式

using System;
using System.Reflection.PortableExecutable;
using System.Resources;
using System.Text.RegularExpressions;

//实例
// public class Example
// {
    // public static void Main()
    // {
    //     string input = "1851 1999 1950 1905 2003";
    //     string pattern = @"(?<=19)\d{2}\b";
    //
    //     foreach (Match match in Regex.Matches(input, pattern))
    //     Console.WriteLine(match.Value);
    //     }
// }

//实例1
namespace RegExAPPlication
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        // static void Main(string[] args)
        // {
        //     string str = "A Thousand Splendid Suns";
        //
        //     Console.WriteLine("Matching words that start with 'S': ");
        //     showMatch(str, @"\bS\S*");
        //     Console.ReadKey();
        // }
    }
}

//实例2
namespace Application11
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression:"+expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        // static void Main(string[] args)
        // {
        //     string str = "make maze and mange to measure it";
        //     
        //     Console.WriteLine("Matching words start woth 'm' and ends with 'e':");
        //     showMatch(str,@"\bm\S*e\b");
        //     Console.ReadKey();
        // }
    }
}

//实例3
namespace Application2
{
    class Myclass
    {
        // static void Main(string[] args)
        // {
        //     string input = "Hello World";
        //     string pattern = "\\s+";
        //     string replacement = "";
        //     Regex rgx = new Regex(pattern);
        //     string result = rgx.Replace(input, replacement);
        //     
        //     Console.WriteLine("Original String:{0}",input);
        //     Console.WriteLine("Replacement String:{0}",result);
        //     Console.ReadKey();
        // }
    }
}