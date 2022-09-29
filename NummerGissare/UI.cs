using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummerGissare
{
  public class UI
  {
    private High_Score scoreList = new High_Score();
    private List<Score> printList = new List<Score>();
    
    public UI()
    {
    }
    public static String DrawUI()
    {
      string path = @"C:\Users\ollec\source\repos\NummerGissare - Copy\NummerGissare\HS.txt";
      Console.WriteLine("Välkommen till Gissa Numret!!!");
      Console.WriteLine("");
      Console.WriteLine("Här ser du tidigare gissningar: ");

      if (File.Exists(path))
      {
          foreach (string line in System.IO.File.ReadLines(path))
          {
            System.Console.WriteLine(line);

          }
      }
      else
      {
        Console.WriteLine("Ingen tidigare data finns, du har nu chansen att bli först!!");
      }
      Console.WriteLine("");
      Console.WriteLine("Vill du spela <ja/nej>? ");
      return Console.ReadLine();
    }
  }
}