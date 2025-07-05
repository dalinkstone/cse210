using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

// to get 5 videos
// https://www.googleapis.com/youtube/v3/search?part=snippet&q=YOUR_SEARCH_QUERY&type=video&maxResults=5&key=YOUR_API_KEY
//
// to get details of the 5 videos
// https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics,contentDetails&id=VIDEO_ID1,VIDEO_ID2,VIDEO_ID3,VIDEO_ID4,VIDEO_ID5&key=YOUR_API_KEY
//
// to get 5 comments from the 5 videos
// https://www.googleapis.com/youtube/v3/commentThreads?part=snippet&videoId=VIDEO_ID&maxResults=5&key=YOUR_API_KEY

public class YouTubeApiClient
{
    private HttpClient _httpClient;
    private string _baseUrl = "https://googleapis.com/youtube/v3/";
    private string _apiKey = Environment.GetEnvironmentVariable("YOUTUBE_API_KEY");

    public YouTubeApiClient(string apiKey)
    {
        _apiKey = apiKey;
        _httpClient = new HttpClient();
    }

    private string BuildUrl(string endpoint, Dictionary<string, string> parameters)
    {
        string query = "";

        parameters["key"] = _apiKey;

        foreach (KeyValuePair<string, string> item in parameters)
        {
            query += item.key + "=" + item.value + "&";
        }

        return _baseUrl + endpoint + "?" + query;
    }

    private string CallApi(string endpoint, Dictionary<string, string> parameters)
    {
        string url = BuildUrl(endpoint, parameters);

        HttpResponseMessage response = _httpClient.GetAsync(url).Result;

        string json = response.Content.ReadAsStringAsync().Result;

        return json;
    }


    public string GetSearchVideos()
    {
        var parameters = new Dictionary<string, string>
        {
            ["part"] = "snippet",
            ["q"] = "programming",
            ["type"] = "video",
            ["maxResults"] = "5",
        };

        string response = CallApi("search", parameters);

        return JsonSerializer.Deserialize<string>(response);
    }

    private Video GetVideo(string videoId)
    {
        var parameters = new Dictionary<string, string>
        {
            ["part"] = "snippet,statistics,contentDetails",
            ["id"] = videoId,
        };

        string response = CallApi("videos", parameters);

        // return JsonSerializer.Deserialize<string>(response);

        string videoTitle = "";
        string videoAuthor = "";
        int videoLength = ;

        Video newVideo = Video(videoId, videoTitle, videoAuthor, videoLength);

        return newVideo;
    }

    public List<Video> GetVideos(List<string> videoIds)
    {
        List<Video> videos = new List<Video>();

        foreach (string videoId: videoIds)
	{
            videos += GetVideo(videoId);
        }

        return videos;
    }

    private Comment GetComment(string videoId)
    {
        var parameters = new Dictionary<string, string>
        {
            ["part"] = "snippet",
            ["videoId"] = videoId,
            ["maxResults"] = "5",
        };

        string response = CallApi("commentThreads", parameters);

        // return JsonSerializer.Deserialize<string>(response);

        string commentId = "";
        string commentAuthor = "";
        string commentContent = "";

        Comment newComment = Comment(commentId, commentAuthor, commentContent);

        return newComment;
    }

    public List<Comment> GetComments(List<string> videoIds)
    {
        List<Comment> comments = new List<Comment>();

        foreach (string videoId: videoIds)
	{

        }

        return comments;
    }

}
