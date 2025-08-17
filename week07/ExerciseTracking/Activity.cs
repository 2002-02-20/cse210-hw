using System;
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    // Constructor
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date { get { return _date; } }
    public int Minutes { get { return _minutes; } }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityName();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityName()} ({_minutes} min) - " +
               $"Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} km/h, " +
               $"Pace: {GetPace():F2} min per km";
    }
}