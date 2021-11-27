using System;

namespace lab6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6 Задание 5 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkRed;


            Console.WriteLine("Введите значение х");
            int x = Convert.ToInt32(Console.ReadLine());


            double y = 4*(Math.Pow((x - 3), 6)) - 7*(Math.Pow((x - 3), 3)) + 2;
            Console.WriteLine($"Значение функции равно {y}");


            Console.ReadKey();
        }
    }
}
