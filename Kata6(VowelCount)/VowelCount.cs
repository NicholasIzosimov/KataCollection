using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
      char[] vowelArray = new char[] { 'a', 'e', 'i', 'o', 'u' } ;
      int count = 0;
      // check each char in str if it matches something in the array
      foreach(char letter in str)
      {
        if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter== 'u' )
        {
          count += 1;
        }
      }
      return count;
    }
  }