using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int age;
        int weekday;

        Console.WriteLine("Please enter your age and the day of the week");
        Console.WriteLine("");

        Console.Write("age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("day of the week: ");
        // Monday - 1
        // Tuesday - 2
        // Wednesday - 3
        // Thursday - 4
        // Friday - 5
        // Sunday - 6
        // Saturday - 7
        weekday = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if ((weekday == 2 || weekday == 4) || (age >= 12 && age <= 21))
        {
            Console.WriteLine("You are eligible for student pricing!");
        }
        else
        {
            Console.WriteLine("You must pay regular pricing.");
        }

        Console.WriteLine("\nDone.");
    }
}