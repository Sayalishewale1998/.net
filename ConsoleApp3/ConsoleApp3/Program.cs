using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][]jagged_array = new int[][]
            {
                new int[]{1,2},
                new int[]{1,2,3},
                new int[]{1,2,3,4},
                new int[]{1,2,3,4,5}
            };
            for (int i=0; i<jagged_array.Length; i++)
            {
                for(int j=0; j<jagged_array[i].Length; j++)
                {
                    Console.Write("");
                }
                Console.WriteLine();
            }
        }
    }
}
