using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameUsers = new string[4];
            for (int i = 0; i < nameUsers.Length; i++)
            {
                Console.WriteLine("Введите имя");
                string firstName = Console.ReadLine();
                Console.WriteLine("Фамилия");
                string lastName = Console.ReadLine();
                Console.WriteLine("Отчество");
                string patronymic = Console.ReadLine();
                string name = GetFullName(firstName, lastName, patronymic);

                nameUsers[i] = name;
                Console.WriteLine();
                Console.WriteLine("Имя Фамилия Отчество");
                Console.WriteLine($"{nameUsers[i]}");   // отображение ФИО на каждом шаге
                Console.WriteLine();
            }

            Console.WriteLine("Таблица");
            Console.WriteLine("Имя Фамилия Отчество");
            foreach (string curenUserName in nameUsers) // отображения всех запросов одновреммено
            {
                Console.WriteLine(curenUserName);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static string GetFullName(string firstName, string lastName, string patronymic) // Сложение в одну строку
        {
            string fullName = $"{firstName} {lastName} {patronymic}";

            return fullName;

        }

    }
}
