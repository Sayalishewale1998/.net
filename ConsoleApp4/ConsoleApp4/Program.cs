using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main1(string[] args)
        {
            int num = 2000;

            object obj = num;
            num = 500;
            Console.WriteLine("value - type value of num is :{0}", "\n num=" +num);
            Console.WriteLine("Object - type value of num is :{0}", "\n obj=" +obj);
        }
    }
}
