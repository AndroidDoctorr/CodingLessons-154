public class StreamingContentRepository
{
    // The Repository Pattern

    // 1. A collection of objects and
    // 2. A set of methods that control how it is accessed

    // Our collection will be a List, but we will pretend it's a database
    private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

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
        return _contentDirectory;
    }

    public StreamingContent GetContentByTitle(string title)
    {
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

        return _contentDirectory.Remove(content);
    }
}