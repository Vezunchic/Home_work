using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lesson_5_Test_3

{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ввести с клавиатуры произвольный набор чисел");
            
            string numbers = Console.ReadLine();
            string cleanString = NewString( numbers ); // убирает все кроме чисел
            int cleanNumber = Convert.ToInt32(cleanString);
            Line newline = new Line()
            {
                Number = cleanNumber
            };
            

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream address = new FileStream("Line.bin", FileMode.OpenOrCreate);
            formatter.Serialize(address, newline);
            address.Close();
            Console.WriteLine("Обьект сериализован");
        }
        static string NewString(string numbers)// Метод убирает все кроме чисел
        {
            string accumulator = "";

            for (int i = 0; i < numbers.Length; i++) 
            {
                char symbol = numbers[i];
                string newString = symbol.ToString();
                bool resuTryParse = Int32.TryParse(newString, out int sign);
                if (resuTryParse)
                {
                    accumulator = accumulator + sign.ToString();
                }

            }

            return accumulator;
        }
    }
    [Serializable]
    public class Line 
    {
        private int _number = 0;
        public int Number 
        {
            set
            {
                _number = value;
            }
        }   
        
       



    }
}
