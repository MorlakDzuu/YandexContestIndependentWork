using System;

namespace taskF
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            uint n;
            double sum = 0;
            // Проверяем входные данные, если они не верны, то выводим "wrong" и завершаем работу программы.
            if (!double.TryParse(Console.ReadLine(), out a) || !UInt32.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("wrong");
                return;
            }
            // Выводим сумму с точностью 3 знака после запятой.
            Console.WriteLine("{0:#.000}", GetSunGeometricProgression(a, n));
        }

        /// <summary>
        /// Метод вычисляет сумму геометрической прогрессии.
        /// </summary>
        /// <param name="a">элемент геометрической прогресии</param>
        /// <param name="n">конечная степень элемента</param>
        /// <returns></returns>
        private static double GetSunGeometricProgression(double a, uint n)
        {
            double sum = 0;
            // Считаем сумму.
            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }

            return sum;
        }
    }
}