using System.Data;
using MathGame.Models;

namespace MathGame;

internal class GameEngine
{
    internal void OperateGame(GameType operation)
    {
        var message = $"{operation} selected";
        Dictionary<GameType, char> symbolTypeMap = new()
        {
            {GameType.Addition, '+' }, {GameType.Subtraction, '-'}, {GameType.Multiplication, '*'}, {GameType.Division, '/'}
        };

        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            var numbers = Helpers.GetNumbers(operation);
            int firstNumber = numbers.Item1;
            int secondNumber = numbers.Item2;

            Console.Clear();
            Console.WriteLine(message);

            Console.WriteLine($"{firstNumber} {symbolTypeMap[operation]} {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            int answer = operation switch
            {
                GameType.Addition => firstNumber + secondNumber,
                GameType.Subtraction => firstNumber - secondNumber,
                GameType.Multiplication => firstNumber * secondNumber,
                GameType.Division => firstNumber / secondNumber
            };

            if (int.Parse(result) == answer)
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

        Helpers.AddToHistory(score, operation);

    }
}