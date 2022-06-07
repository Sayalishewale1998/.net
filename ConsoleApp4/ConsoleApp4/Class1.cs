using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class1
    {
        public static void sum()
        {
            int sum = 5 + 4;
            Console.WriteLine(sum);
        }
        public static void sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void sum(int a,int b,int c)
        {
            int sum = a + b + c;
            Console.WriteLine(sum);
        }
        public static void sum(string a,string b)
        {
            int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
                Console.WriteLine(sum);
        }
        public static void Main23()
        {
            sum();
            sum(5, 4, 9);
            sum(5, 4);
            sum("5", "6");
        }
    }
}
