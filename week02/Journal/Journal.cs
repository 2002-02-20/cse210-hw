using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string entryText)
    {
        DateTime theCurrentTime = DateTime.Now;

        Entry entry = new Entry();
        entry._date = "Date and Actualy Hour: " + theCurrentTime.ToString("dd/MM/yyyy HH:mm:ss");
        entry._promptText = new PromptGenerator().GetRandomPrompt(); 
        entry._entryText = entryText; 
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry localEntry in _entries)
        {
            localEntry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|~|{entry._promptText}|~|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); 
         if (File.Exists(file)) 
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(new string[] { "|~|" }, StringSplitOptions.None);
                    if (parts.Length == 3) 
                    {
                        Entry entry = new Entry
                        {
                            _date = parts[0],
                            _promptText = parts[1],
                            _entryText = parts[2]
                        };
                        _entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("The file is not exist.");
        }
    
    }
}