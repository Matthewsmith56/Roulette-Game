using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    
    public class Program
    {
        public Wheel Wheel = new Wheel();
        public static BetLocation BetLocation = new BetLocation();
        public MenuClass MenuClass = new MenuClass();

        public static int beginingCredits = 1000;
        public static int betAmount = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roulette table, you currently have 1000 credits");
            MenuClass.Menu();
        }
        
        public static void CheckFunds()
        {
            Console.WriteLine("You currently have {0} Credits press enter to continue", beginingCredits);
            Console.ReadKey();
            Console.WriteLine();
            MenuClass.Menu();
        }

        public static void BetOnNumber()
        {
            Console.WriteLine("What is your bet amount?");

            int betAmount = Convert.ToInt32(Console.ReadLine());

            if (betAmount > beginingCredits || betAmount <= 0)
                Console.WriteLine("Insufficient Funds");
            else if (betAmount <= beginingCredits)
                Console.WriteLine("your current bet is {0}", betAmount);
            Console.WriteLine();
            BetLocation.BetSelection();
        }
    }
}
