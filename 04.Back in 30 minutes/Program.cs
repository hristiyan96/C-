using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int hh = int.Parse(Console.ReadLine());
        int mm = int.Parse(Console.ReadLine());

        mm += 30;
       
        if(mm > 60)
        {
            hh ++;
            mm = mm - 60;

        }
         if(hh >= 24)
        {
           hh = hh - 24;
        }
         if(mm < 10)
        {
            Console.WriteLine($"{hh}:{mm:d2}");
            
        }
         else if(mm >= 10)
        {
            Console.WriteLine($"{hh}:{mm}");
        }
          
    }
}