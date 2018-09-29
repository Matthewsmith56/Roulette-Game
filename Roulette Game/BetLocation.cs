using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            int betAmount = Program.betAmount;
            Console.WriteLine("Select your number by typing it in then press enter\n " +
                              "1,2,3,4,5,6,7,8,9,10,\n" +
                              "11,12,13,14,15,16,17,18,19,20,\n" +
                              "21,22,23,24,25,26,27,28,29,30,\n" +
                              "31,32,33,34,35,36,0, or 00");

            string tempLocation = Convert.ToString(Console.ReadLine());

            int betLocation = 100;

            if (tempLocation != "00" && tempLocation != "0")
            {
                int num1 = Convert.ToInt32(tempLocation);
                betLocation = num1;
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
                Program.beginingCredits += betAmount * 35;
                Console.WriteLine("CONGRATULATIONS, YOU WON");
                BetSelection();
            }
            else
            {
                Program.beginingCredits -= betAmount;
                Console.WriteLine("Sorry, try again. Press enter to continue");
            }
            Console.ReadKey();
            Console.Clear();
            MenuClass.Menu();
        }
    }
}
