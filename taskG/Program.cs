using System;

namespace taskG
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            // Проверяем входные данные, если они не верны, то выводим "wrong" и завершаем работу программы.
            if (!int.TryParse(Console.ReadLine(), out n) || (n <= 0))
            {
                Console.WriteLine("wrong");
                return;
            }
            // Выводим сумму.
            Console.WriteLine(GetSumReversedFactorials(n).ToString("G6"));
        }

        /// <summary>
        /// Метод считает сумму чисел, обратных факториалам.
        /// </summary>
        /// <param name="n">конечное число в факториале</param>
        /// <returns>сумма чисел, обратных факториалам</returns>
        private static decimal GetSumReversedFactorials(int n)
        {
            decimal sum = 1;
            long factorialN = 1;
            // Считаем сумму.
            for (int i = 2; (i <= n + 1) && (factorialN != 0); i++)
            {
                sum += (decimal) 1 / factorialN;
                factorialN *= i;
            }

            return sum;
        }
    }
}