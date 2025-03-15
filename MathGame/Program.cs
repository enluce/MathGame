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
if (gameSelected == "a")
{
    Console.WriteLine("Addition game selected.");
}
else if (gameSelected == "s")
{
    Console.WriteLine("Subtraction game selected");
}
else if (gameSelected == "m")
{
    Console.WriteLine("Multiplication game selected");
}
else if (gameSelected == "d")
{
    Console.WriteLine("Division game selected");
}
else if (gameSelected == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid Input");
}