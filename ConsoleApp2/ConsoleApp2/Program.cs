using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Secondhigh
    {
        static void Main()
        {
            int Max1, Max2;
            int[] arr = { 21, 20, 56, 52, 41, 23, 32, 54, 97, 85 };
            Console.WriteLine("Array Elements are :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Max1 = Max2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max1)
                {
                    Max2 = Max1;
                    Max1 = arr[i];
                }
                else if (arr[i] > Max2)
                {
                    Max2 = arr[i];
                }

            }
            Console.WriteLine("second highest number :" + Max2);
            Console.ReadLine();
        }
    }
}

