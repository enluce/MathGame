namespace MathGame.Models;

internal class Game
{
    // private int _score; // Backing Field

    // public int Score
    // {
    //     get { return _score; } //Getter
    //     set { _score = value; } //Setter
    // }
    
    public int Score { get; set; }
    public DateTime Date { get; set; }
    public GameType Type { get; set; }
    
    
    //A model class will hold properties that are related so the game class has properties which are characteristics of the game.
    
    
    //When a property has a limited number of options like the game Type here, we can associate it with constants using an Enumeration.
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication, 
    Division
}