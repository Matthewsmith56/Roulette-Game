using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    public class BetLocation
    {
        
        public int[] Roulette = new[]
        {
            1,2,3,4,5,6,7,8,9,10,
            11,12,13,14,15,16,17,18,
            19,20,21,22,23,24,25,26,
            27,28,29,30,31,32,33,34,
            35,36,0,00
        };
        public void BetSelection()
        {
            Console.WriteLine("Place your bet by entering 0, 00, or numbers 1 - 36 " +
                              "and pressing enter");
            if (Console.ReadLine() == "0")
            {
                int betNumber = 37;
            }
            else if (Console.ReadLine() == "00")
            {
                int betNumber = 38;
            }
        }
    }
}
