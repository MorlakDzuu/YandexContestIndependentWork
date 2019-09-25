using System;

namespace taskA
{
    class Program
    {
        private static int a, b;
        static void Main(string[] args)
        {
            // Проверяем, являются ли введенные пользователем значения целочисленными.
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
            {
                // Если введенные значения целочисленные, то меняем содержимое переменных a и b с помощью вспомогательной переменной c.
                 Swap_A_B();
                // Выводим результат.
                Console.WriteLine(a + " " + b);
            }
            // Если введены непраильные значения, то пишем "wrong"
            else
            {
                Console.WriteLine("wrong");
            }
        }

        /// <summary>
        /// Метод меняет содержимое переменных a и b.
        /// </summary>
        private static void Swap_A_B()
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
    }
}