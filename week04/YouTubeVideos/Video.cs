using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _durationInSeconds;
    private List<VideoComment> _comments;

  
    public Video(string title, string author, int durationInSeconds)
    {
        _title = title;
        _author = author;
        _durationInSeconds = durationInSeconds;
        _comments = new List<VideoComment>();
    }

    
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetDurationInSeconds()
    {
        return _durationInSeconds;
    }

    public void SetDurationInSeconds(int duration)
    {
        _durationInSeconds = duration;
    }

    
    public void AddComment(VideoComment comment)
    {
        _comments.Add(comment);
    }

    
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

   
    public List<VideoComment> GetComments()
    {
        return _comments;
    }

    
    private string FormatDuration()
    {
        int minutes = _durationInSeconds / 60;
        int seconds = _durationInSeconds % 60;
        return $"{minutes}:{seconds:D2}";
    }

    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Duration: {FormatDuration()} ({GetDurationInSeconds()} seconds)");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        
        if (_comments.Count == 0)
        {
            Console.WriteLine("  No comments yet.");
        }
        else
        {
            foreach (VideoComment comment in _comments)
            {
                Console.WriteLine(comment.GetFormattedComment());
            }
        }
        Console.WriteLine(); 
    }
}