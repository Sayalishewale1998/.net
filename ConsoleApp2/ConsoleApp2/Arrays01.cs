using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Arrays01
    {
        public static void Main()
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];


            //Input arr1
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please Enter the value value for arr1[" + row + " , " + col + " ]:");
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
          
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please Enter the value value for arr2[" + row + " , " + col + " ]:");
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());

                }
            }
            /*
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine((arr1[row,col] * arr2[row,col])+"\t");
                }/*
            }


        }


    }
}
