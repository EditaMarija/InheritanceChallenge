namespace InheritanceChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Learning about inheritance in C#", true, "Marija");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out this new web design", "Marija",
                "https://image.com/marijadesign", true);

            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("SomeVideo", "Marija",
                "https://video.com/somevideo", true, 10);

            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}