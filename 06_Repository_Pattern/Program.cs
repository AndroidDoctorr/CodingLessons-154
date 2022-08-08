StreamingContent contentItem = new StreamingContent(
    "The Room",
    "Everyone hates Johnny and he's fed up with this world",
    5,
    Maturity.R,
    Genre.Drama
);

Console.WriteLine($"{contentItem.Title} is rated {contentItem.MaturityRating}");

System.Console.WriteLine($"Is {contentItem.Title} family friendly? {(contentItem.IsFamilyFriendly ? "Yes" : "No")}");
System.Console.WriteLine("\n\n\n\n");
System.Console.WriteLine(contentItem.ToString());