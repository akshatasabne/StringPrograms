using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class Class
    {
        static void Main(string[] args)
        {
          //  int a = 0;

            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 1, 2, 7, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                int a = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        a = 1;
                        break;
                    }

                    //if (a==0)
                    //    Console.WriteLine(arr[i]);
                }
                if (a == 0)
                    Console.WriteLine(arr[i]);
            }
        }
        }
    }
