using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();
        // Video 1 instances and adding comments
        Video video1 = new Video("Public Speaking", "Open Classrooms", 3100);
        video1.AddComment(new Comment("Sabb", "Underrated!"));
        video1.AddComment(new Comment("Janeehauya", "How to prepare for various professional context is just Wow!"));
        video1.AddComment(new Comment("Ghalib", "Nice course, Thank you for making it."));
        videos.Add(video1);

        // Video 2 instances and adding comments
        Video video2 = new Video("CS50 2D", "Flappy Bird", 9890);
        video2.AddComment(new Comment("Pedro", "Godot is an engine, Love2D is a framework there's a whole level of abstraction above, love and lua is more bare bones."));
        video2.AddComment(new Comment("Rahul", "I think Godot has it's own scripting language!"));
        video2.AddComment(new Comment("Gabriel", "Lua is a extension language, it's used together with other technologies"));
        videos.Add(video2);

        // Video 3 instances and adding comments 
        Video video3 = new Video("The Case for optimism on Climate Change", "Al Gore", 1521);
        video3.AddComment(new Comment("Krokonil", "The greatest American President that never was..."));
        video3.AddComment(new Comment("Dylan", "The people who need to hear this won't sit through the whole thing"));
        video3.AddComment(new Comment("Xapemanx", "Think of the world we could have lived in if Al Gore didn't get robbed of his presidency"));
        videos.Add(video3);

        foreach (Video video in videos) // Loop through each video and display comments
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }

    }
}