using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;



    public void Display()
{
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Question: {_promptText}");
    Console.WriteLine($"Entry: {_entryText}");
    Console.WriteLine();
}

}   