using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        public static void Main()
        {
            int[] ar = new int[5];
            int[] ar1 = new int[] { 1, 2, 3, 4, 5 };
            
            int[] ar3 = new int[5];

            for (int i=0; i< ar1.Length; i++)
            {
                Console.WriteLine(ar1[i]);
            }
            string name = "sayali";
            for(int i=0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
