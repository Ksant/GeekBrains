using System;
using System.Text;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static string CreateFIO(string firstName, string secondName, string patronymic)
            {
                return $"{secondName} {firstName} {patronymic}";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(CreateFIO("Петр ", "Петров", "Петрович"));
            sb.AppendLine(CreateFIO("Алексей ", "Алексеев", "Алексеевич"));
            sb.AppendLine(CreateFIO("Петр ", "Смирнов", "Евгеньевич"));
            sb.AppendLine(CreateFIO( "Селезень ", "Уткин", "Орлович"));

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}
