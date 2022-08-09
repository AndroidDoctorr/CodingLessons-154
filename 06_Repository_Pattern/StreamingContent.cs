public enum Genre
{
    Uncategorized, Action = 1, Horror, Comedy, RomCom, Drama, Bromance, Fantasy, Documentary
}

public enum Maturity { U, G, PG, PG_13, R, NC_17, TV_G, TV_PG, TV_Y, TV_MA }

public class StreamingContent
{
    public StreamingContent() { }
    public StreamingContent(string title,
                            string description,
                            double starRating,
                            Maturity maturityRating,
                            Genre genre)
    {
        Title = title;
        Description = description;
        StarRating = starRating;
        MaturityRating = maturityRating;
        Genre = genre;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public double StarRating { get; set; }
    public Maturity MaturityRating { get; set; }
    public bool IsFamilyFriendly
    {
        get
        {
            // return true for family friendly maturity ratings ONLY
            // 0. switch expression
            return MaturityRating switch
            {
                Maturity.G => true,
                Maturity.PG => true,
                Maturity.TV_G => true,
                Maturity.TV_PG => true,
                Maturity.TV_Y => true,
                _ => false,
            };

            // 1. if/else - check for each maturity rating and return the appropriate value
            if (MaturityRating == Maturity.G)
            {
                return true;
            }
            else if (MaturityRating == Maturity.PG)
            {
                return true;
                // etc....
            }
            else
            {
                return false;
            }
            // 2. switch/case
            switch (MaturityRating)
            {
                case Maturity.PG:
                case Maturity.G:
                case Maturity.TV_Y:
                    // etc...
                    return true;
                default:
                    return false;
            }

            // 3. use enum values...
            /*
            if ((int)MaturityRating >= 100)
                return false;
            else
                return true;
            */
        }
    }
    public Genre Genre { get; set; }


    public override string ToString()
    {
        return $"{Title}:\n{Description.Substring(0, 25) + "..."}\n{Genre}, Rated {MaturityRating}";
    }
}