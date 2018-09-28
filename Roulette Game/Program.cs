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
        public BetLocation BetLocation = new BetLocation();

        public static int creditsTotal = 1000;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roulette table, you currently have 1000 credits");
            PlaceBet();
        }
        
        public static void PlaceBet()
        {
            Console.WriteLine("What is your bet amount?");
            int betAmount = Convert.ToInt32(Console.ReadLine());

            if (betAmount > creditsTotal || betAmount <= 0)
                Console.WriteLine("Insufficient Funds");
            else if (betAmount <= creditsTotal)
                Console.WriteLine("your current bet is {0}", betAmount);
        }
    }
}
