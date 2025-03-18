namespace MathGame;
internal class Menu
{
    GameEngine engine = new GameEngine();
    internal void ShowMenu(string? name, DateTime date)
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your maths game. That's great that you're working on improving yourself!\n");
        Console.WriteLine("\n");

        bool isGameOn = true;

        do
        {
            Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
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
                    engine.AdditionGame("Addition game ");
                    break;
                case "s":
                    engine.SubtractionGame("Subtraction game ");
                    break;
                case "m":
                    engine.MultiplicationGame("Multiplication game ");
                    break;
                case "d":
                    engine.DivisionGame("Division game ");
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