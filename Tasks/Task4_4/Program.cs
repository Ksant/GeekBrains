using System;
using System.Data;
using System.Text;

namespace Task4_4
{
    class Program
    {
        static long[] fibanachy = new long[100];
        static int lastCalculatedNumber = 0;
        static void Main(string[] args)
        {
            fibanachy[0] = 1;
            fibanachy[1] = 1;
            FibonacciRecurse(92);
            StringBuilder sb = new StringBuilder();
            foreach (var item in fibanachy)
            {
                sb.AppendLine(item.ToString());
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        static long FibonacciRecurse(int currItem)
        {
            if (currItem > 1 && lastCalculatedNumber < currItem)
            {
                fibanachy[currItem] = FibonacciRecurse(currItem - 1) + FibonacciRecurse(currItem - 2);
                lastCalculatedNumber = currItem;
                return fibanachy[currItem];
            } else
            {
                return fibanachy[currItem];
            }
        }
    }
}
