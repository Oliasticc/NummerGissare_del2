using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummerGissare
{

  public class GuessNumber
  {

    bool saved = false;
    private bool runGame;
    Random random = new Random();
    Score gameScore = new Score();
    High_Score scoreList = new High_Score();
    List<Score> scores = new List<Score>();
    int input = 0;
    int[] countAr = new int[10];
    int counterGuesses = 0;
    int counterGames = 0;
    int numberToGuess = 0;
    int printCount = 0;

    public GuessNumber()
    {
      
    }

    public void PlayGame(String choice)
    {
     runGame = WillPlay(choice);

      if (runGame == true)
      {
        Console.WriteLine("Skriv in ditt namn!");
        gameScore.Name = Console.ReadLine();
        numberToGuess = random.Next(1, 101);

        while (input != numberToGuess) 
        {

          Console.WriteLine("Gissa nummer 1 - 100");
          counterGames++;
          Console.WriteLine(numberToGuess);
          while (input != numberToGuess)
          {

            if (input != numberToGuess)
            {

              Console.Write("Din gissning: ");
              input = int.Parse(Console.ReadLine());
              counterGuesses++;

              if (input != numberToGuess)
              {
                if (input > numberToGuess)
                {
                  Console.WriteLine("Du gissade för högt... Försök igen! ");
                }
                else
                {
                  Console.WriteLine("Du gissade för lågt... Försök igen! ");
                }
              }
            }
          }
          gameScore.Guess = counterGuesses;
          countAr[counterGames - 1] = counterGuesses;
          scores.Add(gameScore);
          scores.Sort();
          scores.Reverse();
          saved = scoreList.SaveScore(scores);
          scores.Clear();
          Console.WriteLine("Bra Jobbat! Det tog dig {0} gissningar!", counterGuesses);
          Console.WriteLine("Vill du spela igen <ja/nej> ? ");
          runGame = WillPlay(Console.ReadLine());

          if (runGame == true)
          {
            numberToGuess = random.Next(1, 101);
            input = 0;
            counterGuesses = 0;
            gameScore.Guess = 0;

          } else
          {
            foreach (var item in countAr)
            {
              if (item != 0)
              {
                printCount++;
                Console.WriteLine("Runda {0} tog dig {1} gissningar! ", printCount, item);
              }
            }
          }
        }
        
        
      } else
      {
        Console.WriteLine("nehe fuck u då!");
      }

      Console.ReadLine();

    }

    private bool WillPlay(String choice)
    {
      if (choice == "ja")
      {
        return true;
      } else
      {
        return false; 
      }
      
    }
  }
}
