public class Kata
{
  public static string SortMyString(string s)
  {
    var oddIndex = "";
    var evenIndex = "";
    for(var i = 0; i < s.Length; i++)
    {
      if(i % 2 == 0 || i == 0) evenIndex += s[i];
      if(i % 2 != 0) oddIndex += s[i];
    }
    return evenIndex + " " + oddIndex;
  }
}