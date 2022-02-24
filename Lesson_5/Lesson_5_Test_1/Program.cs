using System;
using System.IO;
namespace Lesson_5_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры набор данных");
            string dataSet = Console.ReadLine();
           
            File.WriteAllText("file_1.txt", dataSet);
            
            string dataSet2 = File.ReadAllText("file_1.txt");
            Console.WriteLine(dataSet2);
        }
    }
}
