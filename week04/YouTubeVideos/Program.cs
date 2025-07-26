using System;

class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("=== YOUTUBE VIDEO MONITORING SYSTEM ===\n");

    
        List<Video> videoList = new List<Video>();

        // Create Video 1
        Video video1 = new Video("How to Program in C# - Complete Tutorial", "TechMaster", 1820);
        video1.AddComment(new VideoComment("John Smith", "Excellent tutorial! Really helped with my project."));
        video1.AddComment(new VideoComment("Sarah Johnson", "Could you make a video about interfaces?"));
        video1.AddComment(new VideoComment("Mike Davis", "Very well explained, thanks for sharing."));
        video1.AddComment(new VideoComment("Emma Wilson", "Subscribed! Looking forward to more content like this."));
        videoList.Add(video1);

        // Create Video 2
        Video video2 = new Video("Object-Oriented Programming Made Easy", "CodeAcademy", 945);
        video2.AddComment(new VideoComment("Alex Chen", "Finally understood the concepts, thank you!"));
        video2.AddComment(new VideoComment("Lisa Brown", "What's the difference between class and object?"));
        video2.AddComment(new VideoComment("David Miller", "Perfect for my exam tomorrow."));
        videoList.Add(video2);

        // Create Video 3
        Video video3 = new Video("Data Structures in C# - Arrays and Lists", "DevEducation", 1350);
        video3.AddComment(new VideoComment("Robert Taylor", "The examples are very clear."));
        video3.AddComment(new VideoComment("Jennifer Garcia", "When should I use Array vs List?"));
        video3.AddComment(new VideoComment("Michael Anderson", "This channel always has great content."));
        video3.AddComment(new VideoComment("Amanda White", "Sharing this with my classmates."));
        videoList.Add(video3);

        // Create Video 4
        Video video4 = new Video("Debugging and Error Handling in C#", "ProgrammingPro", 720);
        video4.AddComment(new VideoComment("Chris Martinez", "Very useful for debugging my programs."));
        video4.AddComment(new VideoComment("Jessica Lee", "Could you talk about try-catch blocks?"));
        video4.AddComment(new VideoComment("Daniel Rodriguez", "Thanks for the debugging tips."));
        videoList.Add(video4);

        
        Console.WriteLine($"Total videos in database: {videoList.Count}\n");
        
        int videoCounter = 1;
        foreach (Video video in videoList)
        {
            Console.WriteLine($"--- VIDEO {videoCounter} ---");
            video.DisplayVideoInfo();
            videoCounter++;
        }

        Console.WriteLine("=== END OF REPORT ===");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

