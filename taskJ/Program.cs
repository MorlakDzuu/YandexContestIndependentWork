using System;

namespace taskJ
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            // Проверяем входные данные, если они не верны, то выводим "wrong" и завершаем работу программы.
            if (!long.TryParse(Console.ReadLine(), out number) || (number <= 0))
            {
                Console.WriteLine("wrong");
                return;
            }
            // Выводим номер числа в последовательности Фибоначи, если оно входит туда.
            Console.WriteLine(IsFibonachiNumber(number) ? GetNumberOfFibonachi(number) : -1);
        }

        /// <summary>
        /// Метод определяет, входит ли число в последовательность Фибоначи.
        /// </summary>
        /// <param name="number">натуральное число</param>
        /// <returns>true, если число является числом Фибоначи, false, если нет</returns>
        private static bool IsFibonachiNumber(long number)
        {
            return (Math.Sqrt(5 * Math.Pow(number, 2) + 4) % 1 == 0) ||
                   (Math.Sqrt(5 * Math.Pow(number, 2) - 4) % 1 == 0);
        }

        /// <summary>
        /// Метод определяет каким по счету числом Фибоначи является введенное число
        /// </summary>
        /// <param name="number">число Фибоначи</param>
        /// <returns>номер числа в последовательности чисел Фибоначи</returns>
        private static long GetNumberOfFibonachi(long number)
        {
            for (long i = 1; i < number; i++)
            {
                if ((long) GetFibonachiNumber(i) == number)
                {
                    return i;
                }
            }

            return -1;
        }
        
        /// <summary>
        /// Метод возвращает число Фибоначи n-го порядка
        /// </summary>
        /// <param name="n">позиция числа в последовательности Фибоначи</param>
        /// <returns>приблизительное число Фибоначи n-го порядка</returns>
        static double GetFibonachiNumber(long n)
        {
            double fNumb;
            double b = (1 + Math.Sqrt(5)) / 2.0;
            fNumb = (Math.Pow(b, n) - (-Math.Pow(b, -n))) / (2 * b - 1);
            return fNumb;
        }
        
    }
}