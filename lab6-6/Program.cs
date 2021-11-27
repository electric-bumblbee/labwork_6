using System;

namespace lab6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6 Задание 6 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkCyan;


            Console.WriteLine("Введите значение A");
            int A = Convert.ToInt32(Console.ReadLine());

            double A2 = A*A;
            double A4 = A2*A2;
            double A8 = A4*A4;

            

            Console.WriteLine($"Значение функции равно {A8}");


            Console.ReadKey();
        }
    }
}
