  using System.Linq;

  namespace Solution
  {
    class Kata
      {
      public static int find_it(int[] seq) 
        {
        for(int j = 0; j < seq.Length; j++)
        {
          int countForThisNumber = 0;
            for(int n = 0; n < seq.Length; n++)
            {

                  if(seq[j] == seq[n])
                  {
                    countForThisNumber++;
                  }
            }
          if(countForThisNumber % 2 == 1) return seq[j];
        }
          return -1;

      }

      }
  }