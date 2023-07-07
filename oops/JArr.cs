using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class JArr
    {
        public void display()
        {
            int[][] numbers = new int[4][];
            numbers[0] = new int[] { 1, 2, 35};
            numbers[1] = new int[] { 11, 34, 25, 84 };
            numbers[2] = new int[] { 41, 49 };
            numbers[3] = new int[] { 99 };

            Console.WriteLine(numbers[0][2]);

            for(int i=0;i<numbers.Length;i++)
            {
                Console.Write("Rows({0}) :" , i);
                for(int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write("{0}",numbers[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        public void displayMULTI()
        {
            int[][,] numbers = new int[4][,]
            {
            new int[,] { { 1, 3 }, { 5, 7 } },
            new int[,] { { 9,5}, { 11,57 } },
            new int[,] { { 1, 30 }, { 46,48 } },
            new int[,] { { 3,6}, {2,8 } }
        };
            Console.WriteLine(numbers[0][1,1]);

            

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Rows({0}) :", i);
                int x = 0;
                for (int j = 0; j < numbers[i].GetLength(x); j++)
                {
                    for (int k = 0; k < numbers[j].Rank; k++)
                    {
                        Console.Write( numbers[i][j,k] + " ");
                }
                Console.WriteLine();
            }x++;
        }
    }
}
}//"Jagged_Array [" + i + "]" + "[" + j + "]" + "[" + "]" + "[" + k + "]" + "[" +"]"+
