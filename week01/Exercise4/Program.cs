using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int writeNum;
        int white = 0;
        int a = 0;
        int average = 0;
        int largest = 0;

        do
        {
            Console.Write("Enter number: ");
            writeNum = int.Parse(Console.ReadLine());
            if (writeNum != 0)
            {
                numbers.Add(writeNum);
            }

        } while (writeNum != 0);

        foreach (int oneNum in numbers)
        {
            
            white += oneNum;
            if (largest < oneNum)
            {
                largest = oneNum;
            }

        }
        a = numbers.Count;
        if (a > 0)
        {
            average = white / a;
        }

        

        Console.WriteLine($"The sum is: {white}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}