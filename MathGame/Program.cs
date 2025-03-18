using System.ComponentModel.DataAnnotations;
using MathGame;

var menu = new Menu();

var date = DateTime.UtcNow; // DateTime datatype. this datatype does need to be initialized unlike others and there are a bunch of ways to do it. here we are calling the utcnow method to do it.
var name = Helpers.GetName();

menu.ShowMenu(name, date);

