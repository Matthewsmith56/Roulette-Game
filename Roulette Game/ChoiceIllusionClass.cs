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
            FourtySixPrecentClass.FourtySixPrecent();
        }
        public static void RedOrBlack()
        {
            Console.WriteLine("Would you like to bet on Red or Black?" +
                              "\n1 = Red" +
                              "\n2 = Black");
            string myInput = Console.ReadLine();
            FourtySixPrecentClass.FourtySixPrecent();
        }

        public static void BetOnLowsOrhighs()
        {
            Console.WriteLine("Would you like to bet on Low or High?" +
                              "\n1 = Low: 1 - 18" +
                              "\n2 = high: 19 - 36");
            string myInput = Console.ReadLine();
            FourtySixPrecentClass.FourtySixPrecent();
        }

        public static void BetOnDozen()
        {
            Console.WriteLine("Which dozen you like to bet on?" +
                              "\n1 = 1 - 34" +
                              "\n2 = 2 - 35" +
                              "\n3 = 3 - 36");
            string myInput = Console.ReadLine();
            ThirtyTwoPrecentClass.ThirtyTwoPrecent();
        }

        public static void OneBetOnColumns()
        {
            Console.WriteLine("What column would you like to bet on?" +
                              "\n1 = 1 - 12" +
                              "\n2 = 13 - 24" +
                              "\n3 = 25 - 36");
            string myInput = Console.ReadLine();
            ThirtyTwoPrecentClass.ThirtyTwoPrecent();
        }

        public static void BetOnStreet()
        {
            Console.WriteLine("What street would you like to bet on?" +
                              "\n1 = 1 - 3" +
                              "\n2 = 4 - 6" +
                              "\n3 = 7 - 9" +
                              "\n4 = 10 - 12" +
                              "\n5 = 13 - 15" +
                              "\n6 = 16 - 18" +
                              "\n7 = 19 - 21" +
                              "\n8 = 22 - 24" +
                              "\n9 = 24 - 27" +
                              "\n10 = 28 - 30" +
                              "\n11 = 31 - 33" +
                              "\n12 = 34 - 36");
            string myInput = Console.ReadLine();
            ElevenPrecentClass.ElevenPrecent();
        }

        public static void BetOnDoubleStreet()
        {
            Console.WriteLine("What double street would you like to bet on?" +
                             "\n1 = 1 - 6" +
                             "\n2 = 7 - 12" +
                             "\n3 = 13 - 18" +
                             "\n4 = 19 - 24" +
                             "\n5 = 25 - 30" +
                             "\n6 = 31 - 36");
            string myInput = Console.ReadLine();
            SixteenPrecentClass.SixteenPrecent();
        }

        public static void BetOnSplit()
        {
            Console.WriteLine("enter any two adjacent numbers and press enter");
            Console.WriteLine();
            Console.WriteLine("|3|6|9|12|15|18|21|24|27|30|33|36|\n" +
                              "|2|5|8|11|15|17|20|23|26|29|32|35|\n" +
                              "|1|4|7|10|13|16|19|22|25|28|31|34|");
            string myInput = Console.ReadLine();
            FivePrecentClass.FivePrecent();
        }

        public static void BetOnIntersect()
        {
            Console.WriteLine("What four intersecting numbers would you like to bet on?" +
                              "\n1 = 1,2,4,5            11 = 2,5,3,6" +
                              "\n2 = 4,5,7,8            12 = 5,8,8,6" +
                              "\n4 = 10,11,13,14        13 = 8,11,12,9" +
                              "\n5 = 13,14,16,17        14 = 11,14,15,12" +
                              "\n5 = 16,17,19,20        15 = 14,17,18,15" +
                              "\n6 = 19,20,22,23        16 = 17,20,21,18" +
                              "\n7 = 22,23,25,26        17 = 20,23,24,21" +
                              "\n8 = 25,26,28,29        18 = 23,26,27,24" +
                              "\n9 = 28,29,31,32        19 = 26,29,30,27" +
                              "\n10 = 31,32,34,35       20 = 29,32,33,30"+ 
                                                     "\n21 = 32,35,36,33");


            string myInput = Console.ReadLine();
            TenPrecentClass.TenPrecent();
        }
    }
}
