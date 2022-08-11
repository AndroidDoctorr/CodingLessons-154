

public class StreamingContentRepository
{
    // The Repository Pattern

    // 1. A collection of objects and
    // 2. A set of methods that control how it is accessed

    // Our collection will be a List, but we will pretend it's a database
    protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    // Methods to control access (CRUD)
    // Create
    public bool AddContentToDirectory(StreamingContent content)
    {
        // Data validation
        // if (invalid for some reason) {
        //    return;
        // }

        int startingCount = _contentDirectory.Count;
        _contentDirectory.Add(content);
        bool wasAdded = _contentDirectory.Count > startingCount;
        return wasAdded;
    }
    // Read
    public List<StreamingContent> GetAllContent()
    {
        return _contentDirectory.Where(sc => sc.IsActive).ToList();
    }

    public List<StreamingContent> GetAllDeletedContent()
    {
        return _contentDirectory.Where(sc => !sc.IsActive).ToList();
    }

    // Get a List of Family friendly contents
    public List<StreamingContent> GetFamilyFriendlyContent()
    {
        List<StreamingContent> familyFriendlyContents = new List<StreamingContent>();
        // look at EACH content, ADD IF it's family friendly

        foreach (StreamingContent item in GetAllContent())
        {
            if (item.IsFamilyFriendly)
            {
                familyFriendlyContents.Add(item);
            }
        }

        return familyFriendlyContents;

        // This is LINQ, a fancier way of doing this
        return GetAllContent().Where(sc => sc.IsFamilyFriendly).ToList();
    }

    public List<StreamingContent> GetContentsByGenre(Genre genre)
    {
        return _contentDirectory.Where(sc => sc.Genre == genre).ToList();
    }




    // CHALLENGE: 
    // Write a method that gets all Contents with a star rating of at least X stars
    public List<StreamingContent> GetContentsByRating(double stars)
    {
        // The LINQ way
        return _contentDirectory.Where(c => c.StarRating >= stars).ToList();

        // The long (more readale) way
        List<StreamingContent> matchingContent = new List<StreamingContent>();
        foreach (StreamingContent item in _contentDirectory)
        {
            if (item.StarRating >= stars)
            {
                matchingContent.Add(item);
            }
        }

        return matchingContent;
    }

    public List<StreamingContent> SearchForContents(string? query)
    {
        if (query == null) return new List<StreamingContent>();

        return _contentDirectory.Where(
            sc => sc.Title.ToLower().Contains(query.ToLower())
        ).ToList();
    }




    // Be careful making things nullable!!!
    public StreamingContent? GetContentByTitle(string title)
    {
        // LINQ version
        return _contentDirectory.FirstOrDefault(
            sc => sc.Title.ToLower() == title.ToLower()
        );

        foreach (StreamingContent content in _contentDirectory)
        {
            if (content.Title.ToLower() == title.ToLower())
            {
                return content;
            }
        }
        return null;
    }
    // Update

    public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
    {
        StreamingContent oldContent = GetContentByTitle(originalTitle);
        if (oldContent == null)
        {
            return false;
        }

        oldContent.Title = newContent.Title;
        oldContent.Description = newContent.Description;
        oldContent.StarRating = newContent.StarRating;
        oldContent.MaturityRating = newContent.MaturityRating;
        oldContent.Genre = newContent.Genre;

        return true;
    }

    // Delete
    public bool DeleteExistingContent(string title)
    {
        StreamingContent content = GetContentByTitle(title);

        if (content == null)
        {
            return false;
        }

        // return _contentDirectory.Remove(content);
        content.IsActive = false;
        return true;
    }
}