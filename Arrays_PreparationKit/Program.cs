using System;

namespace Arrays_PreparationKit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[,] arr1 = new int[6, 6];
            int[,] arr2 = new int[6, 6];
            Console.Write("Input elements in the matrix :\n");


            arr1[0, 0] = 1;
            arr1[0, 1] = 1;
            arr1[0, 2] = 1;
            arr1[0, 3] = 0;
            arr1[0, 4] = 0;
            arr1[0, 5] = 0;


            arr1[1, 0] = 0;
            arr1[1, 1] = 1;
            arr1[1, 2] = 0;
            arr1[1, 3] = 0;
            arr1[1, 4] = 0;
            arr1[1, 5] = 0;

            arr1[2, 0] = 1;
            arr1[2, 1] = 1;
            arr1[2, 2] = 1;
            arr1[2, 3] = 0;
            arr1[2, 4] = 0;
            arr1[2, 5] = 0;

            arr1[3, 0] = 0;
            arr1[3, 1] = 0;
            arr1[3, 2] = 2;
            arr1[3, 3] = 4;
            arr1[3, 4] = 4;
            arr1[3, 5] = 0;

            arr1[4, 0] = 0;
            arr1[4, 1] = 0;
            arr1[4, 2] = 0;
            arr1[4, 3] = 2;
            arr1[4, 4] = 0;
            arr1[4, 5] = 0;

            arr1[5, 0] = 0;
            arr1[5, 1] = 0;
            arr1[5, 2] = 1;
            arr1[5, 3] = 2;
            arr1[5, 4] = 4;
            arr1[5, 5] = 0;


            //another array
            arr2[0, 0] = -1;
            arr2[0, 1] = -1;
            arr2[0, 2] = 0;
            arr2[0, 3] = -9;
            arr2[0, 4] = -2;
            arr2[0, 5] = -2;


            arr2[1, 0] = -2;
            arr2[1, 1] = -1;
            arr2[1, 2] = -6;
            arr2[1, 3] = -8;
            arr2[1, 4] = -2;
            arr2[1, 5] = -5;

            arr2[2, 0] = -1;
            arr2[2, 1] = -1;
            arr2[2, 2] = -1;
            arr2[2, 3] = -2;
            arr2[2, 4] = -3;
            arr2[2, 5] = -4;

            arr2[3, 0] = -1;
            arr2[3, 1] = -9;
            arr2[3, 2] = -2;
            arr2[3, 3] = -4;
            arr2[3, 4] = -4;
            arr2[3, 5] = -5;

            arr2[4, 0] = -7;
            arr2[4, 1] = -3;
            arr2[4, 2] = -3;
            arr2[4, 3] = -2;
            arr2[4, 4] = -9;
            arr2[4, 5] = -9;

            arr2[5, 0] = -1;
            arr2[5, 1] = -3;
            arr2[5, 2] = -1;
            arr2[5, 3] = -2;
            arr2[5, 4] = -4;
            arr2[5, 5] = -5;

            var hourGlass = new HourGlass(arr2);
            var result = hourGlass.hourglassSumAdvance(); 


            Console.WriteLine("The result is " + result);
        }
    }
}
