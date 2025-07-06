using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string youtubeKey = File.ReadAllText("youtube-api-key.txt").Trim();
        YouTubeApiClient client = new YouTubeApiClient(youtubeKey);

        List<string> videoIds = client.GetSearchVideos();
        List<Video> videos = client.GetVideos(videoIds);
        List<Comment> comments = client.GetComments(videoIds, videos);

        DataParser parser = new DataParser(videos);

        parser.DisplayAll();
    }
}
