using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)
  {
    int[] numbersArray = Array.ConvertAll(n.ToString().ToArray(),x => (int)x - 48);
    var concatNumbers ="";
    for(int i = 0; i < numbersArray.Length; i++)
    {
        concatNumbers += (int)Math.Pow(numbersArray[(i)], 2);
        
    }
    return int.Parse(concatNumbers);
    
  }
}