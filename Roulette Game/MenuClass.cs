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
            Console.WriteLine("What you like to do? " +
                              "\n1 = Bet " +
                              "\n2 = Check Funds");
            var mySelect = Console.ReadLine();
            if (mySelect == "1")
                BetOnNumber();
            if (mySelect == "2")
                BetOnEvenorOdd();
            if (mySelect == "3")
                BetOnRedorBalck();
            if (mySelect == "4")
                BetOnLowsOrhighs();
            if (mySelect == "5")
                BetOnDozen();
            if (mySelect == "6")
                BetOnColumns();
            if (mySelect == "7")
                BetOnStreet();
            if (mySelect == "8")
                BetOnDoubleRows();
            if (mySelect == "9")
                BetOnSplit();
            if (mySelect == "10")
                BetOnIntersect();
            if (mySelect == "11")
                CheckFunds();
            else
                Console.WriteLine("not a Valid input");
            Menu();

        }
    }
}
