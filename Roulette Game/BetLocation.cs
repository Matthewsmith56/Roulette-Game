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
            35,36,37,38
        };

        public static void BetSelection()
        {

            Console.WriteLine("Select your number by typing it in then press enter\n " +
                              "1,2,3,4,5,6,7,8,9,10,\n" +
                              "11,12,13,14,15,16,17,18,19,20,\n" +
                              "21,22,23,24,25,26,27,28,29,30,\n" +
                              "31,32,33,34,35,36,0, or 00");

            string tempLocation = Convert.ToString(Console.ReadLine());

            int betLocation = 100;

            if (tempLocation != "00" && tempLocation != "0")
            {
                 betLocation = Convert.ToInt32(Console.ReadLine());
            }
            else if (tempLocation == "00")
            {
                 betLocation = 37;
            }
            else if (tempLocation == "0")
            {
                 betLocation = 38;
            }

            var random = new Random();
            int winningNumber = random.Next(1, 39);

            if (winningNumber == betLocation)
            {
                Program.creditsTotal += Program.betAmount * 35;
                Console.WriteLine($"CONGRATULATIONS, YOU WON {0} " +
                                  $"Credits! Your current balance is {1}", Program.betAmount * 35, Program.creditsTotal);
                BetSelection();
            }
            else
            {
                Program.creditsTotal -= Program.betAmount;
                Console.WriteLine($"Sorry, try again. You lost {0} Credits", Program.betAmount);
            }
        }
    }
}
