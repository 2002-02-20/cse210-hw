using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade porcentage? ");
        int note = int.Parse(Console.ReadLine());
        string letter = " ";

        if (note >= 90)
        {
            letter = "A";
        }
        else if (note >= 80)
        {
            letter = "B";
        }
        else if (note >= 70)
        {
            letter = "C";
        }
        else if (note >= 60)
        {
            letter = "D";
        }
        else if (note < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your note is: {letter}");

        if (note >= 70)
        {
            Console.WriteLine("You passed. Congratulation!");
            
        }
        else
        {
            Console.WriteLine("You don't passed");
            Console.WriteLine("You need repeat this course");
        }

    }
}