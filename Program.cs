using System;

namespace ConsoleApp
{
     class Program
     {
        static void Main(string[] args)
        {
             //1.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            
            Console.WriteLine("введите  число");

            int number1= Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<= number1; i++)
            if (i%2==0)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        }
        
     }
    
}