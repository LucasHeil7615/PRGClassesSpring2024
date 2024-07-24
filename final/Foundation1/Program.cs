using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("How to Cook Pasta", "Chef Emma", 300);
        Video video2 = new Video("Top 10 Travel Destinations", "TravelWithTom", 600);
        Video video3 = new Video("Guitar Lessons for Beginners", "MusicMan Mike", 150);
        Video video4 = new Video("Yoga for Relaxation", "YogaWithYara", 450);

        // Add comments to videos
        video1.AddComment(new Comment("FoodieFan123", "Great video! I love the recipe."));
        video1.AddComment(new Comment("CookingMama", "Thanks for sharing! Will try this tonight."));
        video1.AddComment(new Comment("GourmetGuru", "Very informative. The tips were helpful."));

        video2.AddComment(new Comment("AdventureAddict", "Amazing content! Can't wait to visit these places."));
        video2.AddComment(new Comment("GlobeTrotter", "Keep up the good work! These are my dream destinations."));

        video3.AddComment(new Comment("StrummingSteve", "Nice tutorial. Easy to follow."));
        video3.AddComment(new Comment("RockNRollRachel", "Learned a lot, thanks! I can play a song now."));

        video4.AddComment(new Comment("ZenMaster", "Awesome video! Feeling relaxed already."));
        video4.AddComment(new Comment("FitnessFreak", "Really enjoyed it. Great way to start the day."));
        video4.AddComment(new Comment("WellnessWarrior", "Great explanation! The breathing techniques are helpful."));
        video4.AddComment(new Comment("MindfulMaddie", "Helpful and clear. Perfect for beginners."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // displays videos 
        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine(new string('-', 40));
        }
    }
}
