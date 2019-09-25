using System;

namespace taskD
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSide, secondSide, thirdSide;
            // Если входные данные неправильны, то выводим "wrong" и завершаем выполнение программы.
            if (!int.TryParse(Console.ReadLine(), out firstSide) ||
                !int.TryParse(Console.ReadLine(), out secondSide) ||
                !int.TryParse(Console.ReadLine(), out thirdSide) ||
                (firstSide < 0) || (secondSide < 0) || (thirdSide < 0))
            {
                Console.WriteLine("wrong");
                return;
            }
            // Выводим результат.
            Console.WriteLine(IsTriangle(firstSide, secondSide, thirdSide) ? (IsRightTriangle(firstSide, secondSide, thirdSide) ?
                              "right" : IsAcuteTriangle(firstSide, secondSide, thirdSide) ? "acute" : "obtuse") : "impossible" );
        }

        /// <summary>
        /// Метод проверяет, существует ли треугольник с такими длинами сторон.
        /// </summary>
        /// <param name="firstSide">длина стороны треугольника</param>
        /// <param name="secondSide">длина стороны треугольника</param>
        /// <param name="thirdSide">длина стороны треугольника</param>
        /// <returns>true, если треугольник с такими сторонами существует, и false, если нет</returns>
        private static bool IsTriangle(int firstSide, int secondSide, int thirdSide)
        {
            return ((firstSide + secondSide) > thirdSide) && ((firstSide + thirdSide) > secondSide) &&
                   ((secondSide + thirdSide) > firstSide);
        }

        /// <summary>
        /// Метод проверяет, прямоугольный ли треугольник с такими длинами сторон.
        /// </summary>
        /// <param name="firstSide">длина стороны треугольника</param>
        /// <param name="secondSide">длина стороны треугольника</param>
        /// <param name="thirdSide">длина стороны треугольника</param>
        /// <returns>true, если треугольник с такими сторонами прямоугольный, и false, если нет</returns>
        private static bool IsRightTriangle(int firstSide, int secondSide, int thirdSide)
        {
            return (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) == Math.Pow(thirdSide, 2)) ||
                   (Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) ||
                   (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2));
        }

        /// <summary>
        /// Метод проверяет, остроугольный ли треугольник с такими длинами сторон.
        /// </summary>
        /// <param name="firstSide">длина стороны треугольника</param>
        /// <param name="secondSide">длина стороны треугольника</param>
        /// <param name="thirdSide">длина стороны треугольника</param>
        /// <returns>true, если треугольник с такими сторонами существует, и false, если нет</returns>
        private static bool IsAcuteTriangle(int firstSide, int secondSide, int thirdSide)
        {
            return (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) > Math.Pow(thirdSide, 2)) &&
                   (Math.Pow(firstSide, 2) < Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) &&
                   (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) > Math.Pow(secondSide, 2));
        }
    }
}