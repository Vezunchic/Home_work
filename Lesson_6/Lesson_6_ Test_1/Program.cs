using System;
using System.Diagnostics;

namespace Lesson_6_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) // завершение процесса с заданными данными через консоль
            {
                if (args[0] == "Kill")
                {
                    KillProcess(args[1]);

                    Console.WriteLine($"Программа завершена");
                }

            }
            else
            {
            
            Process[] fullProcess = Process.GetProcesses();
            Console.WriteLine("Process \t Id");
            Console.WriteLine();
            ListChallengeProcess(fullProcess); //получение списка процессов
            Console.WriteLine("что хотите сделать?");
            Console.WriteLine("Варианты : Завершить процесс(Kill), остановить программу");
            string action = Console.ReadLine();
            TaskManager(action); //запрос на завершение процесса
            
            }
        }
        static void TaskManager(string action)
        {

            try
            {
                if (action == "Завершить процесс" || action == "Kill")
                {
                    Console.WriteLine("Введите имя process или id");
                    string nameProcess = Console.ReadLine();
                    KillProcess(nameProcess); // запрос на закрытие программы
                    
                }
                else
                {
                    Console.WriteLine("Программа завершена");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Не коректно введенно название команды. Ошибка: {ex.Message} ");

            }
           


        }
        static void ListChallengeProcess(Process[] fullProcess)
        {
            for (int i = 0; i < fullProcess.Length; i++)
            {
                Process fistProcess = fullProcess[i];

                Console.WriteLine($"{fistProcess.ProcessName} \t {fistProcess.Id}");

            }


        }
        static void KillProcess(string nameProcess)
        {

            bool resuTryParse = int.TryParse(nameProcess, out int nameProcessId);
            try
            {
                if (resuTryParse)
                {
                    Process processId = Process.GetProcessById(nameProcessId);
                    processId.Kill();
                    Console.WriteLine($"Процесс {nameProcess} завершен");
                }
                else
                {
                    Process[] process = Process.GetProcessesByName(nameProcess);
                    if (process.Length <= 0)
                    {
                        Console.WriteLine($"Не удалось найти процесс.");

                    }
                    foreach (var proces in process)
                    {
                        proces.Kill();
                        Console.WriteLine($"Процесс {nameProcess} завершен");
                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Не получилось завершить процесс. Ошибка:  {ex.Message}");
            }





        }
    }
}
