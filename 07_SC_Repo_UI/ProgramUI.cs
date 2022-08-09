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
                "2. List All Streaming Content\n" + // ✓
                "3. List Family Friendly Content\n" +
                "4. Get Content By Title\n" + // ✓
                "5. Search For Content\n" +
                "6. Update Content Item\n" +
                "7. Remove Content Item\n" +
                "8. Exit" // ✓
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
                case "4":
                    GetContentByTitle();
                    break;
                case "8":
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

        string title = GetValidStringInput("Title");
        string description = GetValidStringInput("Description");

        // Lazy way
        // Console.Write("Please enter a description: ");
        // string description = Console.ReadLine() ?? "";
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

        double starRating;
        bool isValid = false;
        do
        {
            Console.Write("Please enter a rating (0 - 5): ");
            string ratingString = Console.ReadLine() ?? "";

            bool isNumber = double.TryParse(ratingString, out starRating);

            if (isNumber && starRating >= 0 && starRating <= 5.0)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Rating must be a number between 0 and 5");
                PauseAndWaitForKeypress();
            }
        } while (!isValid);


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

        int index = 1;
        foreach (StreamingContent item in _repo.GetAllContent())
        {
            DisplayContentItem(item, index++);
        }

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