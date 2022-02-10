using System;

namespace lesson_4_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            string numbers = Console.ReadLine();            
            Console.WriteLine();
            int sum = NewString(numbers);
            
            Console.WriteLine("Сумма чисел: " + sum);
        }
        static int NewString(string numbers)
        {
            int accumulator = 0;
            for (int i = 0; i < numbers.Length; i++) // убирает пробелы
            {
                char symbol = numbers[i];
                string newString = symbol.ToString();
                bool resuTryParse = Int32.TryParse(newString, out int sign);
                if (resuTryParse == true)
                {
                 accumulator = accumulator + sign;  
                }
            
            }

            return accumulator;
        }

    }
}
