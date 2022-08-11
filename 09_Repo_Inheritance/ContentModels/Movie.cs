public class Movie : StreamingContent
{
    public double RunTime { get; set; }

    public Movie(
        string title,
        string description,
        double rating,
        Maturity maturity,
        Genre genre,
        double runTime
    ) : base(title, description, rating, maturity, genre)
    {
        RunTime = runTime;
    }
}