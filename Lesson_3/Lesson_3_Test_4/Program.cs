using System;

namespace Lesson_3_Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string X, O;
            X = "X";
            O = "O";
            Console.WriteLine(" Морской бой");
            string[,] NewArray = new string[10, 10]
             {
                { X, O, X, O, O, X, O, X, O, X},
                { X, O, X, O, O, X, O, O, O, O},
                { X, O, O, X, O, X, O, X, O, X},
                { O, O, O, X, O, X, O, O, O, O},
                { O, O, O, O, O, O, O, X, X, O},
                { X, X, X, X, O, X, O, O, O, O},
                { O, O, O, O, O, X, O, O, O, O},
                { X, O, O, O, O, X, O, X, X, X},
                { X, O, X, O, O, X, O, O, O, O},
                { X, O, X, O, O, X, O, O, X, X}
             };
            Console.WriteLine();
            PrintAray(NewArray);
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }
        static void PrintAray(string[,] Array)//отображение массива
        {
            int line = Array.GetLength(0); //высота массива
            int column = Array.GetLength(1); //длина массива
            for (int y = 0; y < line; y++)// расчет координаты по высоте
            {
                for (int x = 0; x < column; x++) // расчет координаты по длине
                {
                    Console.Write($"{Array[y, x]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
