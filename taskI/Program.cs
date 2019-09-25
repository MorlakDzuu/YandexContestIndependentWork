using System;

namespace taskI
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            // Проверяем входные данные, если они не верны, то выводим "wrong" и завершаем работу программы.
            if (!long.TryParse(Console.ReadLine(), out number) || (number < 0))
            {
                Console.WriteLine("wrong");
                return;
            }
            // Выводим, является ли число степенью двойки.
            Console.WriteLine(IsPowOfTwo(number) ? "YES" : "NO");
        }

        /// <summary>
        /// Метод проверяет, является ли число степенью двойки.
        /// </summary>
        /// <param name="number">натуральное число</param>
        /// <returns>trut, если число является степенью двойки, false, если нет</returns>
        private static bool IsPowOfTwo(double number)
        {
            if (number == 0)
            {
                return false;
            }
            while ((number != 1) && (number % 2 == 0))
            {
                number = number / 2;
            }
            return (number == 1.0);
        }
    }
}