using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string month = "";
            Console.WriteLine("Введите порядковый номер месяца");
            number = Convert.ToInt32(Console.ReadLine());//"Порядковый номер месяца"
            switch (number)
            {
                case 1:
                    {
                        month = "January";
                        break;
                    }
                case 2:
                    {
                        month = "February";
                        break;
                    }
                case 3:
                    {
                        month = "March";
                        break;
                    }
                case 4:
                    {
                        month = "April";
                        break;
                    }
                case 5:
                    {
                        month = "May";
                        break;
                    }
                case 6:
                    {
                        month = "June";
                        break;
                    }
                case 7:
                    {
                        month = "July";
                        break;
                    }
                case 8:
                    {
                        month = "August";
                        break;
                    }
                case 9:
                    {
                        month = "Semptember";
                        break;
                    }
                case 10:
                    {
                        month = "October";
                        break;
                    }
                case 11:
                    {
                        month = "November";
                        break;
                    }
                case 12:
                    {
                        month = "December";
                        break;
                    }

            }
            Console.WriteLine($"Месяц {month}");
            Console.WriteLine("Нажмите клавишу");
            Console.ReadKey();
        }

    }
}
