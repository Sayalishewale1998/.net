using System;

namespace valuetype
{
    class Program
    {
        static void Main2(string[] args)
        {
            int x = 100, y = 120;
            Console.WriteLine("Before swapping  \na=" + x + " b=" + y);
            Swap(ref x, ref y);

            Console.WriteLine("After swapping  \na=" + x + " b=" + y);
            int result;
            sample(210, out result);
            Console.WriteLine("Out value \na=" + result);
            int result1 = x12();
            int result2, result3, result4;
            x1(out result2, out result3, out result4);

        }
        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("In swap Method \na=" + a + " b=" + b);
        }
        static void sample(int z, out int s)
        {
            s = z + 1;
        }
        static int x12()
        {
            return 1;     
        }
        static void x1(out int s1, out int s2,out int s3)
        {
            s1 = 1;
            s2 = 2;
            s3 = 4;
        }
    }
}
