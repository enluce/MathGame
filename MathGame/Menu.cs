using MathGame.Models;

namespace MathGame;
internal class Menu
{
    GameEngine engine = new GameEngine();
    internal void ShowMenu(string? name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your maths game. That's great that you're working on improving yourself!\n");
        Console.WriteLine("Press any key to show menu");
        Console.ReadLine();
        Console.WriteLine("\n");

        bool isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine(@$"
What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division 
V - View Game History
Q - Quit the program");
            Console.WriteLine("---------------------------------------------");

            var gameSelected = Console.ReadLine().Trim().ToLower();


//use ctrl shift h for find and replace window

//Refactor into a switch statement

            switch (gameSelected)
            {
                case "v":
                    Helpers.PrintGames();
                    break;
                case "a":
                    engine.OperateGame(GameType.Addition);
                    break;
                case "s":
                    engine.OperateGame(GameType.Subtraction);
                    break;
                case "m":
                    engine.OperateGame(GameType.Multiplication);
                    break;
                case "d":
                    engine.OperateGame(GameType.Division);
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
}