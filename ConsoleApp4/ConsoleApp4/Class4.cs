using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class calculator
    {
        public int Number1, Number2;
        public calculator(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public void print()
        {
            Console.WriteLine("Number 1=" + Number1);
            Console.WriteLine("Number 2=" + Number2);
        }
        public static  calculator operator *(calculator c1,calculator c2)
        {
            calculator c3 = new calculator(0, 0);
            c3.Number1= c1.Number1 * c2.Number1;
            c3.Number2 = c1.Number2 * c2.Number2;
            return c3;
        }
    }
    class Class4
    {
        public static void Main5()
        {
            calculator Calculator1 = new calculator(20, 36);
            calculator Calculator2 = new calculator(50, 24);
            calculator Calculator3 = new calculator(0, 0);
            Calculator3= Calculator1 * Calculator2;
            Calculator3.print();

        }
    }
}
