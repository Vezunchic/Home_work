using System;
using System.IO;
namespace Lesson_5_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataSet = "Набор данных: ";
           
            File.WriteAllText("file_1.txt", dataSet);
            File.AppendAllText("file_1.txt", "4513213");
            string dataSet2 = File.ReadAllText("file_1.txt");
            Console.WriteLine(dataSet2);
        }
    }
}
