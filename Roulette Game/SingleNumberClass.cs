using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    public class SingleNumberClass
    {
        
        public int[] Roulette = new[]
        {
            1,2,3,4,5,6,7,8,9,10,
            11,12,13,14,15,16,17,18,
            19,20,21,22,23,24,25,26,
            27,28,29,30,31,32,33,34,
            35,36,37,38
        };
        
        public static void BetOnSingleNumber()
        {
            Console.WriteLine("What is your bet amount?");

            int currentBet = Convert.ToInt32(Console.ReadLine());

            if (currentBet > Program.beginingCredits || currentBet <= 0)
                Console.WriteLine("Insufficient Funds");
            else if (currentBet <= Program.beginingCredits)
            Console.WriteLine();

            Console.WriteLine("Select your number by typing it in then press enter\n " +
                              "1,2,3,4,5,6,7,8,9,10,\n" +
                              "11,12,13,14,15,16,17,\n" +
                              "18,19,20,21,22,23,24,\n" +
                              "25,26,27,28,29,30,31,\n"+
                              "32,33,34,35,36," +
                              "\n Enter 37 for = 0," +
                              "\n Or Enter 38 for = 00");

            int betLocation = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int winningNumber = random.Next(1, 39);

            if (winningNumber == betLocation)
            {
                Program.beginingCredits += currentBet * 35;
                Console.WriteLine("CONGRATULATIONS, YOU WON");
                BetOnSingleNumber();
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
