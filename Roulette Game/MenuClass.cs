using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Game
{
    public class MenuClass
    {
        public static void Menu()
        {
            var mySelect = "0";

            Console.WriteLine("What you like to do? " +
                              "\n1 = Check Funds " +
                              "\n2 = Bet on Single Number" +
                              "\n3 = Bet on Even or Odd" +
                              "\n4 = Bet on Red or Black" +
                              "\n5 = Bet on Low or High" +
                              "\n6 = Bet on Bet on Dozens: For example, row thirds, 1 - 12, 13 - 24, 25 - 36," +
                              "\n7 = Bet on Columns, First Second or Third 12" +
                              "\n8 = Bet on Street 1,2,3, / 4,5,6, / 7,8,9, Ect.." +
                              "\n9 = Bet on Double Street 1,2,3,4,5,6, / 7,8,9,10,11,12, Ect.." +
                              "\n10 = Bet on two number Split 1,2 / 29, 29 Ect.." +
                              "\n11 = Bet on four way intersection 1,2,4,5, Ect..");

            mySelect = Console.ReadLine();

            if (mySelect == "1")
                CheckFunds();
            if (mySelect == "2")
                SingleNumberClass.BetOnSingleNumber();
            if (mySelect == "3")
                ChoiceIllusionClass.OddOrEven();
            if (mySelect == "4")
                ChoiceIllusionClass.RedOrBlack();
            if (mySelect == "5")
                ChoiceIllusionClass.BetOnLowsOrhighs();
            if (mySelect == "6")
                ChoiceIllusionClass.BetOnDozen();
            if (mySelect == "7")
                ChoiceIllusionClass.OneBetOnColumns();
            if (mySelect == "8")
                ChoiceIllusionClass.BetOnStreet();
            if (mySelect == "9")
                ChoiceIllusionClass.BetOnDoubleStreet();
            if (mySelect == "10")
                ChoiceIllusionClass.BetOnSplit();
            if (mySelect == "11")
                ChoiceIllusionClass.BetOnIntersect();
            else
                Console.WriteLine("not a Valid input");
            Menu();
        }

        public static void CheckFunds()
        {
            Console.WriteLine("You currently have {0} Credits press enter to continue", Program.beginingCredits);
            Console.ReadKey();
            Console.WriteLine();
            Menu();
        }
       
    }
}
