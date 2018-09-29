using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    class FivePrecentClass
    {
        public static void FivePrecent()
        {
            Console.WriteLine("What is your bet amount?");

            int currentBet = Convert.ToInt32(Console.ReadLine());

            if (currentBet > Program.beginingCredits || currentBet <= 0)
                Console.WriteLine("Insufficient Funds");
            else if (currentBet <= Program.beginingCredits)
                Console.WriteLine("your current bet is {0}", currentBet);
            Console.WriteLine();

            var random = new Random();
            int winningNumber = random.Next(1, 10001);

            if (winningNumber <= 526)
            {
                Program.beginingCredits += currentBet * 17;
                Console.WriteLine("CONGRATULATIONS, YOU WON, Press enter to continue");
            }
            else
            {
                Program.beginingCredits -= currentBet;
                Console.WriteLine("Sorry, try again. Press enter to continue");
            }
            Console.ReadKey();
            Console.Clear();
            MenuClass.Menu();
        }
    }
}
