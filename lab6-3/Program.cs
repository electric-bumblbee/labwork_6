using System;

namespace lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6 Задание 3 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine("Введите значение A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение В");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Прежние значения: A = {A}, B = {B}, C = {C}");


            int temp = B;
            B = C;
            C = A;
            A = temp;


            Console.WriteLine($"Новые значения: A = {A}, B = {B}, C = {C}");


            Console.ReadKey();
        }
    }
}
