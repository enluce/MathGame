var date = DateTime.UtcNow; // DateTime datatype. this datatype does need to be initialized unlike others and there are bunch of ways to do it. here we are calling the utcnow method to do it.
var name = GetName();

Menu(name);
string? GetName()
{
    Console.WriteLine("Please type your name");
    var name1 = Console.ReadLine();
    return name1;
}


void Menu(string? s)
{
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine($"Hello {s}. It's {date.DayOfWeek}. This is your maths game. That's great that you're working on improving yourself!\n");

    Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division 
Q - Quit the program");
    Console.WriteLine("---------------------------------------------");

    var gameSelected = Console.ReadLine().Trim().ToLower(); 


//use ctrl shift h for find and replace window

//Refactor into a switch statement

    switch (gameSelected)
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);
    
    Console.WriteLine($"{firstNumber} + {secondNumber}");
    string result = Console.ReadLine();

    if (int.Parse(result) == firstNumber + secondNumber)
    {
        Console.WriteLine("Your answer is correct!");
    }
    else
    {
        Console.WriteLine("Your answer is incorrect.");
    }
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

}
void DivisionGame(string message)
{
    Console.WriteLine(message);

}


