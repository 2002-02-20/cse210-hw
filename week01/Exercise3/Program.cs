using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int writeNum;
        do
        {

            Console.Write("What is your guess?");
            writeNum = int.Parse(Console.ReadLine());

            if (number == writeNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (number < writeNum)
            {
                Console.WriteLine("Lower");
            }
            else if (number > writeNum)
            {
                Console.WriteLine("Higher");
            }
        } while (number != writeNum);


    }
}