using System;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №6 Задание 1 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.Green;


            //sH = Interlocked.Exchange(ref sF, sH)
            Console.WriteLine("Введите значение А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение В");
            int B = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Прежние значения: A = {A}, B = {B}");

            int temp = A;
            A = B;
            B = temp;

            Console.WriteLine($"Новые значения: A = {A}  B = {B}");


            Console.ReadKey();
        }
    }
}
