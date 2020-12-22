using System;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dict = new string[5, 2];
            dict[0, 0] = "Alex";
            dict[0, 1] = "8 921 54 65 45 / mknn@Gmail.com";
            dict[1, 0] = "Slon";
            dict[1, 1] = "8 921 54 65 46 / ppc@Gmail.com";
            dict[2, 0] = "Jhon";
            dict[2, 1] = "8 921 54 65 47 / erer@Gmail.com";
            dict[3, 0] = "Alex2";
            dict[3, 1] = "8 921 54 65 4 / werw@Gmail.com";
            dict[4, 0] = "Alex3";
            dict[4, 1] = "8 921 54 65 / werwerwer@Gmail.com";

            for (int i = 0; i < dict.GetLength(0); i++)
            {
                Console.WriteLine($"Имя - {dict[i, 0]}, телефон и почта - {dict[i, 1]}");
            }
            Console.ReadLine();
        }
    }
}
