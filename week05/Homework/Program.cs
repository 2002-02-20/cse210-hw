using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assimnet1 = new Assignment("Derek moscui", "Matte");
        Console.WriteLine(assimnet1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Samuel Ruiz", "Multiplication", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Sussan Storm","European History","The Causes of World War II");

        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}