using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    public class ChoiceIllusionClass
    {
        public static void OddOrEven()
        {
            Console.WriteLine("Would you like to bet on Odd or Even?" +
                              "\n1 = Odd" +
                              "\n2 = Even");
            string myInput = Console.ReadLine();
            OneInFourtySixOddsClass.OneInFourtySix();
        }
        public static void RedOrBlack()
        {
            Console.WriteLine("Would you like to bet on Red or Black?" +
                              "\n1 = Red" +
                              "\n2 = Black");
            string myInput = Console.ReadLine();
            OneInFourtySixOddsClass.OneInFourtySix();
        }

        public static void BetOnLowsOrhighs()
        {
            Console.WriteLine("Would you like to bet on Low or High?" +
                              "\n1 = Low: 1 - 18" +
                              "\n2 = high: 19 - 36");
            string myInput = Console.ReadLine();
            OneInFourtySixOddsClass.OneInFourtySix();
        }

        public static void BetOnDozen()
        {
            Console.WriteLine("Would you like to bet on Low or High?" +
                              "\n1 = Low: 1 - 18" +
                              "\n2 = high: 19 - 36");
            string myInput = Console.ReadLine();
            OneInFourtySixOddsClass.OneInFourtySix();
        }
    }
}
