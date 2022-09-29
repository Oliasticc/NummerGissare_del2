using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummerGissare
{
  public class Score : IComparable<Score>
  {
    private string name = "";
    private int guess = 0;

    public Score()
    {
    }

    public String Name
    {
      set { name = value; }
      get { return name; }
    }

    public int Guess
    {
      set { guess = value; }
      get { return guess; }
    }
    public int CompareTo(Score other) 
     {
       return other.Guess.CompareTo(this.Guess);
     }


  }

 

}
