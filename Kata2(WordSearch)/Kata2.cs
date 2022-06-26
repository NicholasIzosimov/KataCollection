using System.Collections.Generic;
using System;

public class Kata
{
  public static string[] WordSearch(string query, string[] seq)
  {
    List<string> returnArr = new List<string>();
    foreach(var str in seq)
    {
      if(str.ToLower().Contains(query.ToLower()))
      {
         returnArr.Add(str);
      }
    }
    if(returnArr.ToArray().Length < 1) returnArr.Add("Empty");
    return returnArr.ToArray();
  }
}