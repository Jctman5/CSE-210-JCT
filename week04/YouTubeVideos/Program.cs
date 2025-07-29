using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Video 1
            Video video1 = new Video("Learn How to play Guitar", "Guitar Guru", 600);
            video1.AddComment(new Comment("John", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "Could you explain scales next time?"));
            videos.Add(video1);

            // Video 2
            Video video2 = new Video("How to Make Sushi", "Chef Marie", 450);
            video2.AddComment(new Comment("Dan", "I'm hungry now."));
            video2.AddComment(new Comment("Eva", "Turned out perfect!"));
            video2.AddComment(new Comment("Frank", "Add more spciy mayo!"));
            videos.Add(video2);

            // Video 3
            Video video3 = new Video("Top 10 Haunted Locations", "GhostHunter200", 900);
            video3.AddComment(new Comment("Grace", "Watching this with the lights on."));
            video3.AddComment(new Comment("Henry", "So creepy!"));
            video3.AddComment(new Comment("Isla", "Great video!"));
            videos.Add(video3);

            // Video 4
            Video video4 = new Video("Cute dog compilation", "PetZone", 300);
            video4.AddComment(new Comment("Jake", "My dog is cuter!"));
            video4.AddComment(new Comment("Kara", "So cute!"));
            video4.AddComment(new Comment("Liam", "LOL at the last one"));
            videos.Add(video4);

            // Display video info
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  - {comment.CommenterName}: {comment.Text}");
                }
                Console.WriteLine();
            }
        }
    }
}