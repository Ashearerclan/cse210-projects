using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("C# Tutorial", "Tech Guru", 600);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "Loved the explanations.");
        
        Video video2 = new Video("Car Engine Basics", "Auto Expert", 900);
        video2.AddComment("Dave", "This was really informative.");
        video2.AddComment("Eve", "I learned a lot about engines!");
        
        Video video3 = new Video("Space Exploration", "Science Today", 1200);
        video3.AddComment("Frank", "Amazing discoveries!");
        video3.AddComment("Grace", "Excited for the future of space travel.");
        video3.AddComment("Hank", "Thanks for sharing this knowledge!");
        
        List<Video> videos = new List<Video> { video1, video2, video3 };
        
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}