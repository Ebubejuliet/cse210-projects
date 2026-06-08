using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> video = new List<Video>();
        Video video1 = new Video("How to Make a YouTube Video", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Eve", "Can you make a video on editing?"));
        video.Add(video1);

        Video video2 = new Video("C# Programming Tutorial", "Jane Smith", 600);
        video2.AddComment(new Comment("Charlie", "This is exactly what I needed!"));
        video2.AddComment(new Comment("Dave", "Can you make a video on advanced topics?"));
        video2.AddComment(new Comment("Frank", "Thanks for the clear explanations!"));
        video.Add(video2);

        Video video3 = new Video("Travel Vlog: Exploring Japan", "Emily Johnson", 900);
        video3.AddComment(new Comment("Grace", "I love Japan!"));
        video3.AddComment(new Comment("Heidi", "Great vlog, I want to visit Japan now!"));
        video3.AddComment(new Comment("Ivan", "Can you share your itinerary?"));
        video.Add(video3);

        foreach (Video videos in video)
        {
            Console.WriteLine($"Title: {videos.GetTitle()}");
            Console.WriteLine($"Author: {videos.GetAuthor()}");
            Console.WriteLine($"Length: {videos.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {videos.GetComments().Count}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in videos.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }

    }
}