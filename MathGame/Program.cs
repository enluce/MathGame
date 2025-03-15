Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow; // DateTime datatype. this datatype does need to be initialized unlike others and there are bunch of ways to do it. here we are calling the utcnow method to do it.

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your maths game. That's great that you're working on improving yourself!\n");

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
        AdditionGame();
        break;
    case "s":
        SubtractionGame();
        break;
    case "m":
        MultiplicationGame();
        break;
    case "d":
        DivisionGame();
        break;
    case "q":
        Console.WriteLine("Goodbye");
        Environment.Exit(1);
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}

void AdditionGame()
{
    Console.WriteLine("Addition game selected");
}
void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected");
}
void DivisionGame()
{
    Console.WriteLine("Division game selected");
}

