using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    public class Roll
    {
        public static int RollDice()
        {
            Random rndom = new Random();
            int rollDice = rndom.Next(1, 4);

            return rollDice;
        }

        public static string RPScissors(string RPScissorsChoice)
        {
            string computerChoice = Roll.RollDice().ToString();
            if (RPScissorsChoice == "1" && computerChoice == "1")
            {
                return "Tie";
            }
            else if (RPScissorsChoice == "1" && computerChoice == "2")
            {
                return "Lose";
            }
            else if (RPScissorsChoice == "1" && computerChoice == "3")
            {
                return "Win";
            }
            else if (RPScissorsChoice == "2" && computerChoice == "1")
            {
                return "Win";
            }
            else if (RPScissorsChoice == "2" && computerChoice == "2")
            {
                return "Tie";
            }
            else if (RPScissorsChoice == "2" && computerChoice == "3")
            {
                return "Lose";
            }
            else if (RPScissorsChoice == "3" && computerChoice == "1")
            {
                return "Lose";
            }
            else if (RPScissorsChoice == "3" && computerChoice == "2")
            {
                return "Win";
            }
            else if (RPScissorsChoice == "3" && computerChoice == "3")
            {
                return  "Tie";
            }
            else
            {
                return null;
            }
        }
    }
}
