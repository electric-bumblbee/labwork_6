using System;

namespace lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6 Задание 2 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkYellow;


            Console.WriteLine("Введите значение А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение В");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение С");
            int C = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Прежние значения: A = {A}, B = {B}, C = {C}");
            
            int temp = A;
            A = C;
            C = B;
            B = temp;

            Console.WriteLine($"Новые значения: A = {A},  B = {B}, C = {C}");


            Console.ReadKey();
        }
    }
}
