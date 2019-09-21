using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class CardsWar
    {
        public static int Run(string A, string B)
        {
            Dictionary<string, int> CardValues = GenerateCardValues();
            char[] a_deck = A.ToArray();
            char[] b_deck = B.ToArray();
            int alec_wins = 0;
            for(int i=0; i < a_deck.Length; i++)
            {
                if (CardValues[a_deck[i].ToString()] > 
                        CardValues[b_deck[i].ToString()])
                    alec_wins++;
            }
            return alec_wins;
        }

        public static Dictionary<string, int> GenerateCardValues()
        {
            return new Dictionary<string, int>
            {
                { "A", 13 },
                { "K", 12},
                { "Q", 11},
                { "J", 10},
                { "9", 9},
                { "8", 8},
                { "7", 7},
                { "6", 6},
                { "5", 5},
                { "4", 4},
                { "3", 3},
                { "2", 2}
            };
        }
    }
    
}
