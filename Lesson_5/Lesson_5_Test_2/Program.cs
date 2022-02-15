using System;
using System.IO;
namespace Lesson_5_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            File.AppendAllText("startup.txt", DateTime.Now.ToLongTimeString());
            File.ReadAllText("startup.txt");
            
        }
    }
}
