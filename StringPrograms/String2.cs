using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class String2
    {
        static void Main(string[] args)
        {
            //Write a program to count the number of words in a string

            string line = "I am very Greateful";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
         //   Console.WriteLine(

            Console.WriteLine(word);
        }
    }
}
