using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video("C# Programming Tutorial for Beginners", "TechEducators", 3600);
            video1.AddComment(new Comment("Sarah Johnson", "This tutorial is amazing! Very clear explanations."));
            video1.AddComment(new Comment("Mike Chen", "Finally understand object-oriented programming. Thank you!"));
            video1.AddComment(new Comment("Emily Rodriguez", "Could you make a tutorial on LINQ next?"));
            video1.AddComment(new Comment("David Kim", "Best C# tutorial I've found. Subscribed!"));
            videos.Add(video1);

            Video video2 = new Video("10 Minute Morning Workout Routine", "FitLife Daily", 600);
            video2.AddComment(new Comment("Jessica Martinez", "Did this every day for a month and feel great!"));
            video2.AddComment(new Comment("Tom Anderson", "Perfect for busy mornings. Thanks for sharing!"));
            video2.AddComment(new Comment("Lisa Wong", "Can you suggest modifications for beginners?"));
            videos.Add(video2);

            Video video3 = new Video("How to Bake Perfect Chocolate Chip Cookies", "Baker's Kitchen", 840);
            video3.AddComment(new Comment("Rachel Green", "Made these for my family and they were a hit!"));
            video3.AddComment(new Comment("Chris Taylor", "What temperature should I use for a convection oven?"));
            video3.AddComment(new Comment("Amanda Lee", "The tip about chilling the dough made all the difference!"));
            video3.AddComment(new Comment("Brian Foster", "These turned out perfect. My new go-to recipe!"));
            videos.Add(video3);

            Video video4 = new Video("Top 10 Hidden Features in Visual Studio Code", "DevTools Pro", 1200);
            video4.AddComment(new Comment("Kevin Zhang", "I had no idea about #7. Game changer!"));
            video4.AddComment(new Comment("Sophia Patel", "Great video! Very helpful tips."));
            video4.AddComment(new Comment("Alex Turner", "The multi-cursor feature just saved me hours of work."));
            videos.Add(video4);

            Console.WriteLine("===========================================");
            Console.WriteLine("YouTube Video Tracking System");
            Console.WriteLine("===========================================\n");

            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLength()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("\nComments:");
                Console.WriteLine("-------------------------------------------");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  [{comment.GetCommenterName()}]: {comment.GetCommentText()}");
                }

                Console.WriteLine("\n===========================================\n");
            }
        }
    }
}