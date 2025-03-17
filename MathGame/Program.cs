using System.ComponentModel.DataAnnotations;

var date = DateTime.UtcNow; // DateTime datatype. this datatype does need to be initialized unlike others and there are bunch of ways to do it. here we are calling the utcnow method to do it.
var name = GetName();
List<string> games = new List<string>();


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
    Console.WriteLine("\n");

    bool isGameOn = true;

    do
    {
        Console.Clear();
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
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game ");
                break;
            case "s":
                SubtractionGame("Subtraction game ");
                break;
            case "m":
                MultiplicationGame("Multiplication game ");
                break;
            case "d":
                DivisionGame("Division game ");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn = false;
                // Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
                break;
        }
    } while (isGameOn);

}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var score = 0;
    
    Random random = new Random();
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();
        
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer is correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Addition");

}

void SubtractionGame(string message)
{
    
    var score = 0;
    
    Random random = new Random();
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();
        
        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer is correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Subtraction");


}

void MultiplicationGame(string message)
{
    var score = 0;
    
    Random random = new Random();
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();
        
        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer is correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        
        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Multiplication");



}
void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];
        
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();
        
        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer is correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();
        }
    }
    AddToHistory(score, "Division");

}


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);
    
    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    var result = new int[2];

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
    
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("-------------------------------------");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("------------------------------------\n");
    Console.WriteLine("Press any key to return to Main Menu");
    Console.ReadLine();
}

void AddToHistory(int gameScore, string gameType)
    {
        games.Add($"{DateTime.Now} - {gameType}: Score={gameScore}");
    }
