using MathGame;

string? name = GetName();

DateTime date = DateTime.UtcNow;

Menu menu = new Menu();

GameEngine gameEngine = new();

var games = new List<string>();

menu.ShowMenu(name, date);

string GetName()
    {
        Console.WriteLine("Please type your name");
        string? name = Console.ReadLine();
        return name;
    }