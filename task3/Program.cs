using System;

namespace task3
{
    class Program
    {
        static void Main()
        {
            ZDateTime zDateTime = new ZDateTime();
            
            zDateTime.ToFirst();
            
            zDateTime.ToSecond();
            
            Console.WriteLine(zDateTime.FirstFormat);
            
            Console.WriteLine(zDateTime.SecondFormat);
            
            zDateTime.CountDigits();
        }
    }
}