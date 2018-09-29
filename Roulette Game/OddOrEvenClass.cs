using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    public class OddOrEvenClass
    {
        public static void BetOnEvenorOdd()
        {
            Console.WriteLine("What is your bet amount?");

            int currentBet = Convert.ToInt32(Console.ReadLine());

            if (currentBet > Program.beginingCredits || currentBet <= 0)
                Console.WriteLine("Insufficient Funds");
            else if (currentBet <= Program.beginingCredits)
                Console.WriteLine("your current bet is {0}", currentBet);
            Console.WriteLine();
            Console.WriteLine("Would you like to bet on the Odd or Even Numbers" +
                              "\n 1 = Odd" +
                              "\n 2 = Even");

            var random = new Random();
            int winningNumber = random.Next(1, 10001);

            if (winningNumber <= 4632)
            {
                Program.beginingCredits += currentBet * 2;
                Console.WriteLine("CONGRATULATIONS, YOU WON");
                MenuClass.Menu();
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
