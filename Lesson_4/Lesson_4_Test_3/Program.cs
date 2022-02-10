using System;

namespace Lesson_4_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите порядковый номер месяца");
            int number = Convert.ToInt32(Console.ReadLine());//"Порядковый номер месяца"
            if (0 >= number || number > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return;
            }
            else
            {
                Console.WriteLine($"Сезон : {NameSeason(number) }");
            }
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();


           
        }


        static Seasons NameSeason(int number) // определения сезона первый метод
        {

            switch (number)
            {
                case 1:
                case 2:
                case 12:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
            }
                
            return Seasons.Other;

    
        }



        enum Seasons
        {
            Other,
            Winter,
            Spring,
            Summer,
            Autumn
                       }
    }
}
