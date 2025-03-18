using MathGame.Models;

namespace MathGame;

internal class GameEngine
{
    internal void AdditionGame(string message)
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

    Helpers.AddToHistory(score, GameType.Addition);

}

internal void SubtractionGame(string message)
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
    Helpers.AddToHistory(score, GameType.Subtraction);


}

internal void MultiplicationGame(string message)
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
        string? result = Console.ReadLine();
        
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
    Helpers.AddToHistory(score, GameType.Multiplication);



}
internal void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        var divisionNumbers = Helpers.GetDivisionNumbers();
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
    Helpers.AddToHistory(score, GameType.Division);

}



}