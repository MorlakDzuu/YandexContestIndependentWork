using System;

namespace taskH
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, firstCube, secondCube;
            // Проверяем входные данные, если они не верны, то выводим "wrong" и завершаем работу программы.
            if (!int.TryParse(Console.ReadLine(), out number) || (number < 1) || (number > 1028))
            {
                Console.WriteLine("wrong");
                return;
            }

            int[] cubes = GetPairCubes(number);
            if (cubes[0] != -1)
            {
                Console.WriteLine(cubes[0] + " " + cubes[1]);
            }
            else
            {
                // Если после прохождения цикла не нашлась такая пара чисел, то разложить число на сумму двух кубов невозможно.
                Console.WriteLine("impossible");
            }
        }
        
        /// <summary>
        /// Метод находит два куба чисел, сумма которых равна исходному числу.
        /// </summary>
        /// <param name="number">число типа integer</param>
        /// <returns>массив, состоящий из двух кубов, если таких кубов нет, то массив из двух чисел -1</returns>
        private static int[] GetPairCubes(int number)
        {
            int[] cubes = new[] {-1, -1};
            int firstCube, secondCube;
            // Ищем пары чисел, кубы которых в сумме дают введённое число.
            for (int i = 0; i <= Math.Pow(number, 1.0 / 3); i++)
            {
                for (int j = 0; j <= Math.Pow(number, 1.0 / 3); j++)
                {
                    // Проверяем, является ли сумма кубов чисел исходным числом
                    if ((Math.Pow(i, 3) + Math.Pow(j, 3)) == number)
                    {
                        cubes[0] = (Math.Pow(i, 3) > Math.Pow(j, 3)) ? (int) Math.Pow(i, 3) : (int) Math.Pow(j, 3);
                        cubes[1] = (cubes[0] == Math.Pow(i, 3)) ? (int) Math.Pow(j, 3) : (int) Math.Pow(i, 3);
                        break;
                    }
                }
            }

            return cubes;
        }
    }
}