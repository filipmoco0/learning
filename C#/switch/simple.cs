using System;

class Program
{
    static void Main() 
    {
        Console.WriteLine("Choose an option");
        Console.WriteLine("1. The number is divisible by 5.");
        Console.WriteLine("2. The number is divisible by 7.");
        int option = int.Parse(Console.ReadLine());
        int number;
        
        switch (option)
        {
            case 1:
                Console.WriteLine("Enter a value.");
                number = int.Parse(Console.ReadLine());
                if (number % 5 == 0)
                    Console.WriteLine($"The number {number} is divisible by 5.");
                else
                    Console.WriteLine($"The number {number} is not divisible by 5.");
                break;

            case 2:
                Console.WriteLine("Enter a value.");
                number = int.Parse(Console.ReadLine());
                if (number % 7 == 0)
                    Console.WriteLine($"The number {number} is divisible by 7.");
                else
                    Console.WriteLine($"The number {number} is not divisible by 7.");
                break;
        }
    }
}
