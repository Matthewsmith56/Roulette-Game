using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    
    public class Program
    {
        //public static BetLocation BetLocation = new BetLocation();
        public MenuClass MenuClass= new MenuClass();

        public static int beginingCredits = 1000;
        public static int betAmount = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roulette table, you currently have 1000 credits");
            MenuClass.Menu();
        }




        //public static void BetOnNumber()
        //{
        //    Console.WriteLine("What is your bet amount?");

        //    int currentBet = Convert.ToInt32(Console.ReadLine());

        //    if (currentBet > beginingCredits || currentBet <= 0)
        //        Console.WriteLine("Insufficient Funds");
        //    else if (currentBet <= beginingCredits)
        //        Console.WriteLine("your current bet is {0}", currentBet);
        //    Console.WriteLine();
        //}
        
    }
}