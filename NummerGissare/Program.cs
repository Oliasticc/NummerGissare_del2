
using NummerGissare;

void Main()
{
  GuessNumber game = new GuessNumber();
  String choice = "";
  choice = UI.DrawUI();

  game.PlayGame(choice);

}

Main();





