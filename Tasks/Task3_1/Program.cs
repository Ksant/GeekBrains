using System;
using System.Text;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            StringBuilder sb = new StringBuilder();
  
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sb.Append(" ");
                    Console.WriteLine($"{sb.ToString()}{arr[i, j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
