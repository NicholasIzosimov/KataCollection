  using System.Linq;
  using System;
  public static class Kata
  {
      //check if there are an equal amount of x & o's
      public static bool XO(string input)
      {
          var lower = input.ToLower();
          var xCount = 0;
          var oCount = 0;

          foreach (var i in lower)
          {
              if (i == 'o')
              {
                  oCount += 1;
              }
              if (i == 'x')
              {
                  xCount += 1;
              }
          }

          return xCount == oCount;
      }
  }