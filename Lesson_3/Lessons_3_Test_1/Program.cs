using System;

namespace Lessons_3_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] NewArray = new int[3, 3]
            {
                { 5, 10, 25 },
                { 100, 1, 36 },
                { 50, 5, 42 }
            };
            int line = NewArray.GetLength(0); //высота массива
            int column = NewArray.GetLength(1); //длина массива
            Console.Write("Диагональ: ");
            
            for (int y = 0; y < line; y++)// расчет координаты по высоте
            {
                for (int x = 0; x < column; x++) // расчет координаты по длине
                {

                    if (y == 0 && x == 0 || y == 1 && x == 1 || y == 2 && x == 2)//условие диагонали
                    {
                        Console.Write(NewArray[y, x] + ", ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массиф");
            PrintAray(NewArray);
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();

        }
        static void PrintAray(int [,] Array)//отображение массива
        {
            int line = Array.GetLength(0); //высота массива
            int column = Array.GetLength(1); //длина массива
            for (int y = 0; y < line; y++)// расчет координаты по высоте
            {
                for (int x = 0; x < column; x++) // расчет координаты по длине
                {
                    Console.Write($"{Array[y, x]} \t");
                }
                Console.WriteLine();
            }

        }
     
    }
}
