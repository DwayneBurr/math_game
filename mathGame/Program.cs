string? name = GetName();
DateTime date = DateTime.UtcNow;

Menu(name);

void Menu(string? name)
{
    Console.WriteLine("-----------------------------------------------------------------------------------");
    Console.WriteLine($"hello {name?.ToUpper()} its {date.DayOfWeek}\n");
    Console.WriteLine(@"What would you like to play today? choose from the option below:
    A - Addition
    S - Subtract
    M - Multiply
    D - Divide
    Q - Quit");

    Console.WriteLine("-----------------------------------------------------------------------------------");

    string? gameOptions = Console.ReadLine();
    string? gameSelected = gameOptions?.Trim().ToLower();

    switch (gameSelected)
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplyGame("multiply game selected");
            break;
        case "d":
            DivisionGame("division game selected");
            break;
        case "q":
            Console.WriteLine("Quitting...goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Thats not an option try again");
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplyGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

static string? GetName()
{
    Console.WriteLine("Please enter your name");
    string? name = Console.ReadLine();
    return name;
}