using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class String4
    {
        //Write a program to find the first occurrence of a Word in a given string.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter word to find");
            String s2 = Console.ReadLine();

            string[] word = s1.Split(' ');
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == s2)
                {
                    // Console.WriteLine("Word-"+s2);
                    //// Console.WriteLine("Occurence-"+s1);
                    // return;
                    count++;
                }
            }
            // Console.WriteLine("Given word is not present in given string");
            Console.WriteLine(count);
        }
    }
}

