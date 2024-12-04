string? name = GetName();
DateTime date = DateTime.UtcNow;

Menu(name);

void Menu(string? name)
{
    bool isGameOn = true;

    do
    {
    Console.Clear();
    Console.WriteLine("-----------------------------------------------------------------------------------");
    Console.WriteLine($"hello {name?.ToUpper()} its {date.DayOfWeek}\n");
    Console.WriteLine(@"What would you like to play today? choose from the option below:
        A - Addition
        S - Subtract
        M - Multiply
        D - Divide
        Q - Quit"
    );

    Console.WriteLine("-----------------------------------------------------------------------------------");

    string? gameOptions = Console.ReadLine();
    string? gameSelected = gameOptions?.Trim().ToLower();

        switch (gameSelected)
        {
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplyGame("multiply game");
                break;
            case "d":
                DivisionGame("division game");
                break;
            case "q":
                Console.WriteLine("Quitting...goodbye");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    } while(isGameOn);
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();

    int firstNumber;
    int secondNumber;
    int score = 0;

    for(int i = 0; i < 5; i++)
    {
        Console.Clear();
        firstNumber  = random.Next(1, 9);
        secondNumber  = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");

        string? result = Console.ReadLine();


        if(int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct! press enter key for the next question.");
            score ++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("wrong answer! press enter key for the next question.");
            Console.ReadLine();

        }

        if(i == 4)
        {
            Console.WriteLine($"Game over, you scored: {score} press enter key to go back to main menu");
            Console.ReadLine();
        }
    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();

    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");

        string? result = Console.ReadLine();

        if(int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct! press any key for the next question.");
            score ++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("wrong answer! press any key for the next question.");
            Console.ReadLine();

        }
        if ( i == 4)
        {
            Console.WriteLine($"game over, your score is {score}");
        }
    }
}

void MultiplyGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();

    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);
    int score = 0;

    for(int i = 0; i < 5; i++)
    {
        Console.Clear();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        
        Console.WriteLine($"{firstNumber} x {secondNumber}");
        string? result = Console.ReadLine();

        if(int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct! press any key for the next question.");
            score ++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("wrong answer! press any key for the next question.");
            Console.ReadLine();

        }
        if (i == 4)
        {
            Console.WriteLine($"Game over, your score is {score}");
        }
    }
}

void DivisionGame(string message)
{
    int score = 0;
    Console.WriteLine(message);

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        int[] divisionNumber = GetDivisionNumbers();
        int firstNumber = divisionNumber[0];
        int secondNumber = divisionNumber[1];
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        string? result = Console.ReadLine();

        if(int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct! press any key for the next question.");
            score ++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("wrong answer! press any key for the next question.");
            Console.ReadLine();

        }
        if (i == 4)
        {
            Console.WriteLine($"Game over, your score is {score}");
        }
    }
}

static string? GetName()
{
    Console.WriteLine("Please enter your name");
    string? name = Console.ReadLine();
    return name;
}

int[] GetDivisionNumbers()
{
    Random random = new Random();

    int firstNumber = random.Next(1, 99);
    int secondNumber = random.Next(1,99);

    int[] result = new int[2];

    while (firstNumber % secondNumber !=0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}