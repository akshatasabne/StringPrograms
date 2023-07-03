using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and make use of all string functions in it
            string myName = "Akshata Sabne";
            Console.WriteLine(myName);
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName.Length);
            Console.WriteLine(myName.IndexOf('A'));
            Console.WriteLine(myName.LastIndexOf('a'));
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.Contains("Akshata"));
            Console.WriteLine(myName.Equals("Akshata Sabne"));
            Console.WriteLine(myName.GetHashCode());
            Console.WriteLine(myName.Count());
            string myName1 = "Akshay";
            string s = string.Concat(myName, myName1);
            Console.WriteLine(s);
        }
    }
}
