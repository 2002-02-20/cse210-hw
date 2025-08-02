using System;

class ListingActivity : Activity
{
    private int _count;
    public Random _random = new Random();
    public List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public int GetCount()
    {
        return _count;
    }

    public ListingActivity(int count, string prompts, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;

    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public string GetListFromUser()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}