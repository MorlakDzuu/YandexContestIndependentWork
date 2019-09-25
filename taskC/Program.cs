using System;

namespace taskC
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            // Если входные данные неправильны, то выводим "wrong" и завершаем выполнение программы.
            if (!int.TryParse(Console.ReadLine(), out number) || (number < 1) || (number > 100))
            {
                Console.WriteLine("wrong");
                return;
            }
            // Если входные данные верны, то переводим число из арабской в римскую систему.
            Console.WriteLine(GetRomeNumber(number));
        }

        /// <summary>
        /// Метод переводит число из арабской системы в римскую систему счисления.
        /// </summary>
        /// <param name="number">арабское число</param>
        /// <returns>римское число</returns>
        private static string GetRomeNumber(int number)
        {
            return GetRomeTens(number - (number % 10)) + GetRomeOnes(number % 10);
        }

        /// <summary>
        /// Метод переводит десятки из арабской в римскую систему.
        /// </summary>
        /// <param name="number">десятки в арабской системе</param>
        /// <returns>десятки в римской системе</returns>
        private static string GetRomeOnes(int number)
        {
            switch (number)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
            }

            return "";
        }
        
        /// <summary>
        /// Метод переводит единицы из арабской в римскую систему.
        /// </summary>
        /// <param name="number">еденицы в арабской системе</param>
        /// <returns>еденицы в римской системе</returns>
        private static string GetRomeTens(int number)
        {
            switch (number)
            {
                case 10:
                    return "X";
                case 20:
                    return "XX";
                case 30:
                    return "XXX";
                case 40:
                    return "XL";
                case 50:
                    return "L";
                case 60:
                    return "LX";
                case 70:
                    return "LXX";
                case 80:
                    return "LXXX";
                case 90:
                    return "XC";
                case 100:
                    return "C";
            }
            return "";
        }
    }
}