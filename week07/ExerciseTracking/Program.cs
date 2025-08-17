using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));

        activities.Add(new Cycling(new DateTime(2022, 11, 4), 45, 20.0));

        activities.Add(new Swimming(new DateTime(2022, 11, 5), 40, 20));

        activities.Add(new Running(new DateTime(2022, 11, 6), 25, 2.5));
        activities.Add(new Cycling(new DateTime(2022, 11, 7), 60, 25.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 8), 35, 15));


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        for (int i = 0; i < activities.Count; i++)
        {
            Activity activity = activities[i];
            Console.WriteLine($"Activity {i + 1}:");
            Console.WriteLine($"  Type: {activity.GetActivityName()}");
            Console.WriteLine($"  Date: {activity.Date:dd/MM/yyyy}");
            Console.WriteLine($"  Duration: {activity.Minutes} minutes");
            Console.WriteLine($"  Distance: {activity.GetDistance():F2} km");
            Console.WriteLine($"  Speed: {activity.GetSpeed():F2} km/h");
            Console.WriteLine($"  Pace: {activity.GetPace():F2} min/km");
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}