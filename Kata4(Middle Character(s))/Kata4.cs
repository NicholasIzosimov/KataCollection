using System;

public class Kata
{
  public static string GetMiddle(string s)
  {
    var split = s[(s.Length/2)];
    if(s.Length % 2 == 0)
    {
      return s[(s.Length/2) -1].ToString() + split;
    }
    return split.ToString();
  }
}