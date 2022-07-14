using System;

namespace ConsoleApp
{
     class Program
     {
        static void Main(string[] args)
        {
             //1.Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            
            Console.WriteLine("введите первое число");

            int number1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            int number2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите третье число");
            int number3= Convert.ToInt32(Console.ReadLine());

             int max = Math.Max(number1, Math.Max(number2, number3));
             {

                Console.WriteLine("большее число: "+max);
             }

        }
        
     }
    
}