using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace NummerGissare
{

  public class High_Score
  {
    string path = @"C:\Users\ollec\source\repos\NummerGissare - Copy\NummerGissare\HS.txt";
    StreamWriter sw;
    StreamReader sr;
    Score score = new Score();

    public High_Score()
    {
      
      //sReader = new StreamReader(fs);
    }
    public bool SaveScore(List<Score> scores)
    {
      bool test = false;
      try
      {
        using (StreamWriter sw = File.AppendText(path))
        {

          foreach (Score score1 in scores)
          {
            sw.WriteLine($"{score1.Name} gissade {score1.Guess} gånger ");
          }
          
        }

        test = true;
        return true;
      }
      catch (Exception e)
      {
        if (test) throw;
        return false;
      }
    }

    //public List<Score> PrintScore()
    //{
    //  if (File.Exists(path))
    //  {

    //    using (FileStream fs = File.Open(path, FileMode.Append, FileAccess.Write)
    //    {
    //      foreach (string line in System.IO.File.ReadLines(path))
    //      {
    //        System.Console.WriteLine(line);

    //      }
    //    }

    //  }
    //  else
    //  {
    //    Console.WriteLine("Ingen tidigare data finns, du har nu chansen att bli först!!");
    //  }


    //  return scoreList;
    //}

  }
}
