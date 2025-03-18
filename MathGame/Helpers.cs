namespace MathGame;
using MathGame.Models;

internal class Helpers
//Helper Methods are generally static and avoid duplicate code writing and allows us to simply use those methods.
{
    private static List<Game> games = new List<Game>
    {
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
    };
    //Filtering and searching through datasets can be done using C#'s LINQ = Language Integrated Query.
    //Method Syntax vs Query Syntax for LINQ
    
    
    internal static int[] GetDivisionNumbers()
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

    internal static void PrintGames()
    {

        var gamesToPrint = games.Where(x => x.Type == GameType.Division); // Where Clause provided by LINQ and not the List method where predicate consists of a lambda function with parameter on left side and a boolean expression to be evaluated on the right separated by arrow function. True records get added to the output.
        gamesToPrint = games.Where(x => x.Date > new DateTime(2025, 03, 21) && x.Score > 3);
        gamesToPrint = games.Where(x => x.Date > new DateTime(2025, 03, 21)).OrderByDescending(x => x.Score); // Chaining Clauses
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("-------------------------------------");
        foreach (var game in gamesToPrint)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
        }
        Console.WriteLine("------------------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }

    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        // games.Add($"{DateTime.Now} - {gameType}: Score={gameScore}");
        games.Add(new Game
        {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
        });
    }

}