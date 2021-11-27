using System;

namespace lab6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6 Задание 7 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.Cyan;


            Console.WriteLine("Введите значение A");
            int A = Convert.ToInt32(Console.ReadLine());

            double n = Math.Pow(A, 5);
            double AAA = n * n * n;
            

            Console.WriteLine($"Значение функции равно {AAA}");


            Console.ReadKey();
        }
    }
}
