using System;
using System.Text;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length; i > 0; i--)
            {
                sb.Append(str[i-1]);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
