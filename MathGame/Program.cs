﻿var date = DateTime.UtcNow; // DateTime datatype. this datatype does need to be initialized unlike others and there are bunch of ways to do it. here we are calling the utcnow method to do it.
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
        
        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
    
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
        
        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }

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
        
        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }


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
        
        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        
    }

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

