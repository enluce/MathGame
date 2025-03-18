namespace MathGame;
using MathGame.Models;
internal class Helpers
{
    private static List<Game> games = new List<Game>();

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
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("-------------------------------------");
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
        }
        Console.WriteLine("------------------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }

    internal static void AddToHistory(int gameScore, string gameType)
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