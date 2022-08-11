public class Show : StreamingContent
{
    public int SeasonCount { get; set; }
    public int EpisodeCount
    {
        get
        {
            return Episodes.Count;
        }
    }
    public double AverageRunTime
    {
        get
        {
            double totalRunTime = 0;
            foreach (Episode ep in Episodes)
            {
                totalRunTime += ep.RunTime;
            }
            return totalRunTime / EpisodeCount;

            return Episodes.Select(ep => ep.RunTime).ToList().Sum() / EpisodeCount;

            return Episodes.Select(ep => ep.RunTime).Average();
        }
    }

    public List<Episode> Episodes { get; } = new List<Episode>();
}

public class Episode
{
    public string Title { get; set; } = "Untitled Episode";
    public double RunTime { get; set; }
    public int SeasonNumber { get; set; }
}