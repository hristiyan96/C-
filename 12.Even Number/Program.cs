﻿using System;
internal class Program
{
    private static void Main(string[] args)
    {
        
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(n)}");
                break;
            }
            else
            {
                Console.WriteLine("Please write an even number.");
            }
        }
           
       
    }
}