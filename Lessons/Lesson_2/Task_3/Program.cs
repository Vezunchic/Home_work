using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, b;
            Console.WriteLine("Введите число");
            number = Convert.ToDouble(Console.ReadLine());//"Введенное число"
            b = number % 2;
            if (b == 0)
            {
                Console.WriteLine($"Четное");
            }
            else
            {
             Console.WriteLine($"Не четное");
            }
            Console.WriteLine("Нажмите клавишу для закрытия приложения");
            Console.ReadKey();
        }
    }
}
