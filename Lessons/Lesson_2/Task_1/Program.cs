using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите максимальную температуру в °C");
            a = Convert.ToDouble(Console.ReadLine());//"максимальная температура"
            Console.WriteLine("Введите минимальную  температуру в °C");
            b = Convert.ToDouble(Console.ReadLine());// "минимальная температура"
            c = (a + b) / 2;
            Console.WriteLine($"Средняя температура {c} °C" );
            Console.WriteLine("Нажмите клавишу для закрытия приложения");
            Console.ReadKey();
        }
    }
}
