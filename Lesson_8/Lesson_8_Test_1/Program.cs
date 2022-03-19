using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Properties.Settings.Default.Welcome}");
            Console.WriteLine($" Name: {Properties.Settings.Default.Name} Age: {Properties.Settings.Default.Age} Profession: {Properties.Settings.Default.Profession}");
            Console.WriteLine();
            Console.WriteLine("Введите Имя");
            Properties.Settings.Default.Name = Console.ReadLine();      
            Console.WriteLine("Введите возраст");
            Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите род деятельности");
            Properties.Settings.Default.Profession = Console.ReadLine();
            Properties.Settings.Default.Save();

           
        }
    }
}
