using System;

namespace taskB
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            // Считываем входные данные.
            string inputStr = Console.ReadLine();
            // Если входные данные неверные, то выводим "wrong" и завершаем программу.
            if (!int.TryParse(inputStr, out number) || !(inputStr.Length == 4))
            {
                Console.WriteLine("wrong");
                return;
            }
            // Если входные данные верны, то проверяем, является ли число симметричным.
            Console.WriteLine(IsSymmetric(number) ? "1" : "6");
        }

        /// <summary>
        /// Проверяет число на симметричность.
        /// </summary>
        /// <param name="number">число типа integer</param>
        /// <returns>true, если число симметричное, false, если нет</returns>
        private static bool IsSymmetric(int number)
        {
            return (number / 100) == ((number % 10) * 10 + (number % 100 - number % 10) / 10);
        }
    }
}