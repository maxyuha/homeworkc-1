using System;

namespace ConsoleApp
{
     class Program
     {
        static void Main(string[] args)
        {
             //1.Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            
            Console.WriteLine("введите  число");

            int number1= Convert.ToInt32(Console.ReadLine());

            if (number1%2 ==0)
             {

                Console.WriteLine("Число четное");
             }
             else
             {
                Console.WriteLine("Число нечетное");
             }

        }
        
     }
    
}