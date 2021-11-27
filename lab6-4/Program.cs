using System;

namespace lab6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6 Задание 4 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine("Введите значение х");
            double x = Convert.ToDouble(Console.ReadLine());


            double y = 3*(Math.Pow(x, 6)) - 6*(Math.Pow(x, 2)) - 7;
            Console.WriteLine($"Значение функции равно {y}");


            Console.ReadKey();
        }
    }
}
