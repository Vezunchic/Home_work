using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ОАО Комплекс";
            string name2 = "Жемчужина";
            string name3 = "215153-111";
            string name4 = "42";
            string name5 = "2211";
            string name6 = "Alexander G";
            string name7 = "12121";

            System.Console.WriteLine("----------------------------------");
             System.Console.WriteLine($"|         {name}            |");
             System.Console.WriteLine($"|           {name2}             |");
             System.Console.WriteLine($"|        ДОБРО ПОЖАЛОВАТЬ!        |");
             System.Console.WriteLine($"|         Чек {name3}          |");
             System.Console.WriteLine($"|     Комната:{name4} Счет:{name5}        |");
             System.Console.WriteLine($"| КХМ 0012245 ИНН 151543 #5422    |");
             System.Console.WriteLine($"| {DateTime.Now} {name6} |");
             System.Console.WriteLine($"| Услуги _____________            |");
             System.Console.WriteLine($"| Итог     {name7}                  |");
             System.Console.WriteLine($"| Наличными       {name7}           |");
             System.Console.WriteLine($"|     ЭКЛЗ 12311321321            |");
             System.Console.WriteLine($"|_________________________________|");
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу для закрытия приложения");
            Console.ReadKey();
        }
    }

}
