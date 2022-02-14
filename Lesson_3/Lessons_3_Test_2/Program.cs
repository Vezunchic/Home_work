using System;

namespace Lessons_3_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictionary = DictionaryCreator();
            Console.WriteLine();

            Console.WriteLine(" Имя " + " Тел/mail " );
            PrintAray(dictionary);

            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();

        }
        static void PrintAray(string[,] inputDate)//отображение таблицы
        {
            int line = inputDate.GetLength(0); //высота массива
            int column = inputDate.GetLength(1); //длина массива
            for (int y = 0; y < line; y++)// расчет координаты по высоте

            {
                for (int x = 0; x < column; x++) // расчет координаты по длине
                {

                    Console.Write($"{inputDate[y, x]} \t");
                }
                Console.WriteLine();
            }
        }
        static string[,] DictionaryCreator()//расчет
        {
            string[,] dictionary = new string[5, 2];
            int line = dictionary.GetLength(0); //высота массива
            int column = dictionary.GetLength(1); //длина массива

            for (int i = 0; i < line; i++)// расчет координаты по высоте
            {
                for (int j = 0; j < column; j++) // расчет координаты по длине
                {

                    if (j == 0)
                    {
                        Console.WriteLine("Введите Имя");
                        dictionary[i, 0] = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Ввведите номер телефона/e-mail");
                        dictionary[i, 1] = Console.ReadLine();
                    }
                }

                Console.WriteLine();
            }


            return dictionary;
        }
    }
}
