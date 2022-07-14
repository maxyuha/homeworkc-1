using System;

namespace ConsoleApp
{
     class Program
     {
        static void Main(string[] args)
        {
             //1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            
            Console.WriteLine("введите первое число");

            int number1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число");
            int number2= Convert.ToInt32(Console.ReadLine());

             if (number1 > number2)
             {

                Console.WriteLine("меньшее число: "+number2);
                Console.WriteLine("большее число: "+number1);
             }
             else
             {
                Console.WriteLine("меньшее число: "+number1);
                Console.WriteLine("большее число: "+number2);
             }

        }
        
     }
    
}