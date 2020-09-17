using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_PreparationKit
{
    public class HourGlass
    {
        private readonly int[,] matrix;
        public HourGlass(int[,] _matrix)
        {
            this.matrix = _matrix;

        }
        private int hourGlassSumIndependent(int[,] arr)
        {
            int sum = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (row % 2 == 0)
                    {
                        sum += arr[row, column];
                        continue;
                    }
                    if ((row + column) % 2 == 0)
                    {
                        sum += arr[row, column];
                        continue;
                    }
                }

            }


            return sum;
        }

        public int hourglassSumAdvance( )
        {
            int sumMaxHourGlass = 0;
            int[] hourGlasses = new int[16];
            int countHourGlases = 0;
            for (int f = 0; f < 6; f++)
            {

                int maxLengthFila = f + 3;
                if (maxLengthFila > 6) break;

                for (int c = 0; c < 6; c++)
                {
                    int maxLengthColumn = c + 3;
                    if (maxLengthColumn > 6) break;

                    // while (maxLength <= arr[f].Length)  {
                    int fIntern = 0;
                    int cIntern = 0;
                    int sum = 0;

                    int rowOngoing = 0;
                    int columnOngoing = 0;

                    int[,] arrHandleHourGlassIndividually = new int[3, 3];

                    for (fIntern = f; fIntern < maxLengthFila; fIntern++)
                    {
                        columnOngoing = 0;
                        for (cIntern = c; cIntern < maxLengthColumn; cIntern++)
                        {
                            Console.WriteLine("arrGeneral - [{0},{1}] : {2}", fIntern, cIntern, this.matrix[fIntern, cIntern]);
                            //se valida si la fila es Par.

                            arrHandleHourGlassIndividually[rowOngoing, columnOngoing] = this.matrix[fIntern, cIntern];

                            columnOngoing++;
                             
                        }

                        rowOngoing++; 

                    }
                    sum = hourGlassSumIndependent(arrHandleHourGlassIndividually);

                    // maxLength += 3;
                    hourGlasses[countHourGlases] = sum;
                    Console.WriteLine("hourSumGlasses - [{0}] : {1}", countHourGlases, sum);

                    if (countHourGlases == 0)
                    {
                        sumMaxHourGlass = sum;
                    }
                    else if (sumMaxHourGlass < sum)
                    {
                        sumMaxHourGlass = sum;
                    }

                    countHourGlases++;

                     

                }


            }
            return sumMaxHourGlass;
        }

        // Complete the hourglassSum function below.
        static  int hourglassSum(int[][] arr)
        {
            int sumMaxHourGlass = 0;
            int[] hourGlasses = new int[16];
            int countHourGlases = 0;
            for (int f = 0; f < 6; f++)
            {

                int maxLengthFila = f + 3;
                if (maxLengthFila > 6) break;

                for (int c = 0; c < 6; c++)
                {
                    int maxLengthColumn = c + 3;
                    if (maxLengthColumn > 6) break;
                    int fIntern = 0;
                    int cIntern = 0;
                    int sum = 0;

                    int rowOngoing = 0;
                    int columnOngoing = 0;
                    int[,] arrHandleHourGlassIndividually = new int[3, 3];


                    for (fIntern = f; fIntern < maxLengthFila; fIntern++)
                    {
                        columnOngoing = 0;
                        for (cIntern = c; cIntern < maxLengthColumn; cIntern++)
                        {
                            arrHandleHourGlassIndividually[rowOngoing, columnOngoing] = arr[fIntern][cIntern];
                            columnOngoing++;

                        }

                        rowOngoing++;

                    }

                    sum = hourGlassSumI(arrHandleHourGlassIndividually);
                    hourGlasses[countHourGlases] = sum;
                    countHourGlases++;
                    if (countHourGlases == 0)
                    {
                        sumMaxHourGlass = sum;
                    }
                    else if (sumMaxHourGlass < sum)
                    {
                        sumMaxHourGlass = sum;
                    }



                }


            }
            return sumMaxHourGlass;
        }


        /**
         HourGlass sum for former approach
             */
        static int hourGlassSumI(int[,] arr)
        {
            int sum = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (row % 2 == 0)
                    {
                        sum += arr[row,column];
                        continue;
                    }
                    if ((row + column) % 2 == 0)
                    {
                        sum += arr[row,column];
                        continue;
                    }
                }

            }


            return sum;
        }
    }
}
