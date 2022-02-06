using System;

namespace Lesson_3_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            char[] strokaSimvolov = line.ToCharArray();
            Console.WriteLine();
            Console.Write("Реверсия: ");
            for (int symbol = strokaSimvolov.Length - 1; symbol >= 0; symbol--)
            {
                Console.Write(strokaSimvolov[symbol]);

            }
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        } 

    }
}
