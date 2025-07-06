using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName(string userName)
        {
            return userName;
        }

        static int PromptUserNumber(int favNumber)
        {
            return favNumber;
        }

        static int SquareNumber(int numberSquare)
        {
            int resultSquare = numberSquare * numberSquare;
            return resultSquare;
        }

        static void DisplayResult(int resultSquare, string userName)
        {
            Console.WriteLine($"{userName}, the square of your number is {resultSquare}");
        }

        PromptUserName(userName);
        PromptUserNumber(favNumber);
        SquareNumber(favNumber);
        DisplayResult(SquareNumber(favNumber), PromptUserName(userName));
    }
}