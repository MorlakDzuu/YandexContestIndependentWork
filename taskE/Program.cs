using System;
using System.Collections.Generic;

namespace taskE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int numb;
            // Считываем три целых числа,если данные неверны, то выводим "wrong" и завершаем работу программы.
            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(Console.ReadLine(), out numb))
                {
                    numbers.Add(numb);
                }
                else
                {
                    Console.WriteLine("wrong");
                    return;
                }
            }
            // Выводим количество совпадений.
            Console.WriteLine(GetMatchesNumber(numbers));
        }

        /// <summary>
        /// Метод находит количество совпадений элементов списка.
        /// </summary>
        /// <param name="numbers">список с элементами типа integer</param>
        /// <returns>количество совпадений элементов списка</returns>
        private static int GetMatchesNumber(List<int> numbers)
        {
            // Сортируем список, чтобы проще было найти совпадения.
            numbers.Sort();
            // Находим совпадения.
            return (numbers[0] == numbers[2]) ? 3 :
                (numbers[0] == numbers[1]) ? 2 :
                (numbers[1] == numbers[2]) ? 2 : 0;
        }
    }
}