﻿using System;
internal class Program

{
    private static void Main(string[] args)
    {
        float grade = float.Parse(Console.ReadLine());

        if(grade >= 3.00)
        {
            Console.WriteLine($"Passed!");
        }
        else
        {
            Console.WriteLine("(no output)");
        }
    }
}