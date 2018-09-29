using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    
    public class Program
    {
        public MenuClass MenuClass= new MenuClass();

        public static int beginingCredits = 1000;
        public static int betAmount = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roulette table, you currently have 1000 credits");
            MenuClass.Menu();
        }
    }
}