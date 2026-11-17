using System;

namespace Task_1_3
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            double k = GetNumber("Введите жёсткость k (Н/м) = ");
            double x = GetNumber("Введите растяжение x (м) = ");
            double e = GetResult(k, x);

            Console.WriteLine($"k = {k} Н/м; x = {x} м");
            Console.WriteLine($"Потенциальная энергия E = {e} Дж");
        }

        /// <summary>
        /// Вычисляет потенциальную энергию пружины.
        /// </summary>
        /// <param name="k">Жёсткость пружины в Н/м.</param>
        /// <param name="x">Растяжение пружины в метрах.</param>
        /// <returns>Энергия в джоулях.</returns>
        private static double GetResult(double k, double x)
        {
            return k * x * x / 2.0;
        }

        /// <summary>
        /// Считывает число с клавиатуры.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Введённое число.</returns>
        private static double GetNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}
