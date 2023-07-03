using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class String6
    {
           //Write a program to find the first occurrence of a Character in a given string.

        static void Main(string[] args)
        {
            string s = "Good Evening to all";
            Console.WriteLine(s);
            Console.WriteLine("Enter any character");
            char ch = Convert.ToChar(Console.ReadLine());
            char[] chars = s.ToCharArray();
            int count = 0;

            for(int i=0; i<chars.Length; i++)
            {
                if (ch == chars[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
