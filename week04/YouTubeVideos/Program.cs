using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> video = new List<Video>();
        Video video1 = new Video("How to Make a YouTube Video", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video.Add(video1);

        Video video2 = new Video("C# Programming Tutorial", "Jane Smith", 600);
        video2.AddComment(new Comment("Charlie", "This is exactly what I needed!"));
        video2.AddComment(new Comment("Dave", "Can you make a video on advanced topics?"));
        video.Add(video2);

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