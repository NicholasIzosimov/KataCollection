using System;

namespace Solution
{
    public partial class Kata
    {
        public static string DefineSuit(string deck)
        {
            foreach (var card in deck)
            {
                string clubs = "clubs";
                string diamonds = "diamonds";
                string hearts = "hearts";
                string spades = "spades";

                if (deck[^1] == '♣')
                {
                   return clubs;
                }
               
                else if (deck[^1] == '♦')
                {
                    return diamonds;
                }
               
                else if (deck[^1] == '♥')
                {
                    return hearts;
                }
               
                else if (deck[^1] == '♠')
                {
                    return spades;
                }
            }
            return "";
        }
    }
}