public class ProgramUI
{
    private readonly StreamingContentRepository _repo = new StreamingContentRepository();

    public void Run()
    {
        // Seed content
        Seed();
        // Show the menu
        RunMenu();
    }

    private void Seed()
    {
        StreamingContent itemOne = new StreamingContent(
            "The Big Lebowski",
            "The Dude tries to get his rug back",
            5,
            Maturity.R,
            Genre.Comedy
        );

        StreamingContent itemTwo = new StreamingContent(
            "Pi",
            "A mathematician tries to solve the universe, comes up with a 216 digit number",
            5,
            Maturity.R,
            Genre.Drama
        );

        StreamingContent itemThree = new StreamingContent(
            "Hook",
            "Peter Pan returns to Neverland as an adult",
            4.5,
            Maturity.PG,
            Genre.Documentary
        );

        _repo.AddContentToDirectory(itemOne);
        _repo.AddContentToDirectory(itemTwo);
        _repo.AddContentToDirectory(itemThree);
    }

    private void RunMenu()
    {
        bool continueToRun = true;
        while (continueToRun)
        {
            Console.Clear();
            Console.WriteLine(
                "Menu: \n" +
                "1. Create Streaming Content Item\n" + // ✓
                "2. List All Streaming Contents\n" + // ✓
                "3. List Family Friendly Contents\n" + // ✓
                "4. Get Content By Title\n" + // ✓
                "5. Get Contents By Rating\n" + // ✓
                "6. Get Contents By Genre\n" + // CHALLENGE 2
                "7. Search For Content\n" +  // ✓
                "8. Update Content Item\n" +
                "9. Remove Content Item\n" + // ✓
                "0. Exit" // ✓
            );
            // Pause and wait for the user to type something AND THEN ENTER
            string selection = Console.ReadLine() ?? "";

            switch (selection)
            {
                case "1":
                    CreateStreamingContent();
                    break;
                case "2":
                    ListAllContent();
                    break;
                case "3":
                    ListFamilyFriendlyContent();
                    break;
                case "4":
                    GetContentByTitle();
                    break;
                case "5":
                    GetContentsByRating();
                    break;
                case "6":
                    GetContentsByGenre();
                    break;
                case "7":
                    SearchForContent();
                    break;
                case "9":
                    DeleteContentItem();
                    break;
                case "0":
                    continueToRun = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    PauseAndWaitForKeypress();
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
        Thread.Sleep(1000);
    }

    // CRUD Methods
    private void CreateStreamingContent()
    {
        Console.Clear();

        // Lazy way
        // Console.Write("Please enter a description: ");
        // string description = Console.ReadLine() ?? "";

        /*
        Normal way (uncomment this if you don't have the helper method)
        Console.WriteLine(
            "Please select a Maturity Rating:\n" +
            "1. G\n" +
            "2. PG\n" +
            "3. PG-13\n" +
            "4. R\n" +
            "5. NC-17\n" +
            "0. Unrated\n"
        );
        string maturitySelection = Console.ReadLine() ?? "0";
        Maturity maturity = maturitySelection switch
        {
            "1" => Maturity.G,
            "2" => Maturity.PG,
            "3" => Maturity.PG_13,
            "4" => Maturity.R,
            "5" => Maturity.NC_17,
            _ => Maturity.U,
        };
        */

        /*
                Console.WriteLine(
                    "Please select a Genre:\n" +
                    "1. Action\n" +
                    "2. Horror\n" +
                    "3. Comedy\n" +
                    "4. Drama\n" +
                    "5. Rom-Com\n" +
                    "6. Bromance\n" +
                    "7. Fantasy\n" +
                    "8. Documentary\n" +
                    "0. Uncategorized\n"
                );
                string genreSelection = Console.ReadLine() ?? "0";
                Genre genre = genreSelection switch
                {
                    "1" => Genre.Action,
                    "2" => Genre.Horror,
                    "3" => Genre.Comedy,
                    "4" => Genre.Drama,
                    "5" => Genre.RomCom,
                    "6" => Genre.Bromance,
                    "7" => Genre.Fantasy,
                    "8" => Genre.Documentary,
                    _ => Genre.Uncategorized,
                };
                */

        string title = GetValidStringInput("Title");
        string description = GetValidStringInput("Description");
        Maturity maturity = GetValidEnumInput<Maturity>("Maturity Rating");
        Genre genre = GetValidEnumInput<Genre>("Genre");
        double starRating = GetValidDoubleInput("Rating", 0, 5);

        StreamingContent newContent = new StreamingContent(
            title, description, starRating, maturity, genre
        );
        bool wasAdded = _repo.AddContentToDirectory(newContent);

        if (wasAdded)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"{title} added successfully!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Something went wrong, please try again.");
        }
        Console.ResetColor();
        PauseAndWaitForKeypress();
    }


    private void ListAllContent()
    {
        Console.Clear();
        DisplayMultipleContentItems(_repo.GetAllContent());
        PauseAndWaitForKeypress();
    }

    private void GetContentByTitle()
    {
        Console.Clear();
        Console.Write("Please enter a title: ");
        string title = Console.ReadLine() ?? "";   // ?? "" ensures that this won't be null

        StreamingContent item = _repo.GetContentByTitle(title);

        if (item == default)
        {
            Console.WriteLine("Item not found :(");
        }
        else
        {
            DisplayContentItem(item);
        }

        PauseAndWaitForKeypress();
    }

    private void SearchForContent()
    {
        Console.Clear();
        string query = GetValidStringInput("query");
        List<StreamingContent> matches = _repo.SearchForContents(query);
        DisplayMultipleContentItems(matches);
        PauseAndWaitForKeypress();
    }

    private void ListFamilyFriendlyContent()
    {
        Console.Clear();
        DisplayMultipleContentItems(_repo.GetFamilyFriendlyContent());
        PauseAndWaitForKeypress();
    }

    private void GetContentsByRating()
    {
        Console.Clear();
        double rating = GetValidDoubleInput("Rating", 0, 5);

        List<StreamingContent> goodContent = _repo.GetContentsByRating(rating);
        DisplayMultipleContentItems(goodContent);
        PauseAndWaitForKeypress();
    }

    private void GetContentsByGenre()
    {
        // Ask the user for a genre
        Console.Clear();
        Console.WriteLine(
            "Please select a Genre:\n" +
            "1. Action\n" +
            "2. Horror\n" +
            "3. Comedy\n" +
            "4. Drama\n" +
            "5. Rom-Com\n" +
            "6. Bromance\n" +
            "7. Fantasy\n" +
            "8. Documentary\n" +
            "0. Uncategorized\n"
        );
        string genreSelection = Console.ReadLine() ?? "0";
        Genre genre = genreSelection switch
        {
            "1" => Genre.Action,
            "2" => Genre.Horror,
            "3" => Genre.Comedy,
            "4" => Genre.Drama,
            "5" => Genre.RomCom,
            "6" => Genre.Bromance,
            "7" => Genre.Fantasy,
            "8" => Genre.Documentary,
            _ => Genre.Uncategorized,
        };

        // Use the repo method to get all contents in that genre
        List<StreamingContent> genreContents = _repo.GetContentsByGenre(genre);
        // Display the list
        DisplayMultipleContentItems(genreContents);
        // Pause and wait
        PauseAndWaitForKeypress();
    }

    private void DeleteContentItem()
    {
        // Complete this method...

        // Plan the steps with comments (pseudo-code)

        // 1. Find the content
        Console.Clear();
        Console.WriteLine("Delete Content...");
        string title = GetValidStringInput("Title");

        StreamingContent? item = _repo.GetContentByTitle(title);
        if (item == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("404 - Item not found");
            Console.ResetColor();
            PauseAndWaitForKeypress();
            // return means exit the method
            return;
        }
        // 2. Confirm deletion with the user
        // Display the item
        DisplayContentItem(item);
        // Ask "Is this the right one? (y/n)"
        Console.WriteLine("Is this the correct content item? (y/n)");
        // User types "y" or "n", or maybe "yes" or "no" as well
        string response = (Console.ReadLine() ?? "").ToLower();
        // if yes, delete it
        if (response == "y" || response == "yes")
        {
            bool wasDeleted = _repo.DeleteExistingContent(item.Title);
            // UX - we don't actually have to tell the user that we're deleting it
            if (wasDeleted)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Content successfully deleted!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("500 - Couldn't delete content. Please try again.");
                Console.ResetColor();
            }
        }

        PauseAndWaitForKeypress();
    }





    // Helper methods
    private string GetValidStringInput(string name)
    {
        string input;
        do
        {
            Console.Write($"Please enter a {name}: ");
            input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{name} cannot be empty");
                Console.ResetColor();
                PauseAndWaitForKeypress();
            }

        } while (string.IsNullOrWhiteSpace(input));

        return input;
    }

    private double GetValidDoubleInput(string name, double min, double max)
    {
        if (min >= max) throw new Exception("GetValidDoubleInput: Max must be greater than Min");

        double doubleValue;
        bool isValid = false;
        do
        {
            Console.Write($"Please enter a {name} ({min} - {max}): ");
            string doubleString = Console.ReadLine() ?? "";

            bool isNumber = double.TryParse(doubleString, out doubleValue);

            if (isNumber && doubleValue >= min && doubleValue <= max)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine($"{name} must be a number between {min} and {max}");
                PauseAndWaitForKeypress();
            }
        } while (!isValid);

        return doubleValue;
    }

    private T GetValidEnumInput<T>(string name) where T : Enum
    {
        Array vals = Enum.GetValues(typeof(T));
        string displayList = $"Please select a {name}:\n";

        int index = 1;
        Dictionary<string, T> map = new Dictionary<string, T>();
        foreach (T val in vals)
        {
            displayList += $"{index}. {val.ToString()}\n";
            map.Add(index.ToString(), val);
            index++;
        }

        Console.WriteLine(displayList);
        string selection = Console.ReadLine() ?? "0";

        if (map.ContainsKey(selection))
        {
            return map[selection];
        }
        return ((T[])Enum.GetValues(typeof(T)))[0];
    }

    private void DisplayMultipleContentItems(List<StreamingContent> list)
    {
        int index = 1;
        foreach (StreamingContent item in list)
        {
            DisplayContentItem(item, index++);
        }
    }

    private void DisplayContentItem(StreamingContent item)
    {
        Console.WriteLine(
            GetFullContentString(item)
        );
    }
    private void DisplayContentItem(StreamingContent item, int index)
    {
        Console.WriteLine(
            $"{index}. {item.ToString()}"
        );
    }
    private string GetFullContentString(StreamingContent item)
    {
        return $"{item.Title}:\n{item.Description}\n{item.Genre}, Rated {item.MaturityRating}";
    }
    private void PauseAndWaitForKeypress()
    {
        // Pause and wait for a keypress
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}