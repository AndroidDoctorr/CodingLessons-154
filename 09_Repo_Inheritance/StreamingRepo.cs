public class StreamingRepo : StreamingContentRepository
{
    public Movie? GetMovieByTitle(string title)
    {
        foreach (StreamingContent content in _contentDirectory)
        {
            if (content is Movie && content.Title.ToLower() == title.ToLower())
            {
                return (Movie)content;
            }
        }
        return default;
    }

    public Show? GetShowByTitle(string title)
    {
        // return (Show) _contentDirectory.FirstOrDefault(
        //     c => c is Show && c.Title.ToLower() == title.ToLower()
        // );
        StreamingContent? show = _contentDirectory.FirstOrDefault(
            c => c is Show && c.Title.ToLower() == title.ToLower()
        );

        return show == default ? default : (Show)show;
    }

    public List<Show> GetAllShows()
    {
        // return a list of all shows
        List<Show> allShows = new List<Show>();
        foreach (StreamingContent content in _contentDirectory)
        {
            if (content is Show)
            {
                allShows.Add((Show)content);
            }
        }
        return allShows;

        return _contentDirectory
            .Where(c => c is Show)
            .Where(s => s.Title.ToLower()[0] == 'm')
            .Select(c => (Show)c)
            .ToList();

        // foreach content in directory
        //    if content is Show
        //       add to list
        // foreach content in list
        //    if title starts with m
        //       add to secondlist
        // foreach content in secondlist
        //    change content to Show
        //    add to thirdList
        // return thirdList

        List<int> intList = new List<int>() { 1, 2, 3 };
        List<int> incremented = intList.Select(x => x + 3).ToList();
        // { 4, 5, 6 }

        List<string> stringified = intList.Select(x => x.ToString()).ToList();
        // { "1", "2", "3" }
    }
}