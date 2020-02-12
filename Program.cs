using System;
using System.Collections.Generic;

namespace Lab5._1_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("You will now be shown your mortal enemies. Beware. Danger ahead.");
                Console.ReadLine();
                int alive = 25;
                string result;
                List<GameCharacter> gameCharacters = new List<GameCharacter>();

                gameCharacters.Add(new Warrior("Willy Warrior", 35, 10, "sword"));
                gameCharacters.Add(new Warrior("BrideZilla", 22, 11, "SCREAM"));
                gameCharacters.Add(new Wizard("Merlin", 3, 20, 45, 11));
                gameCharacters.Add(new Wizard("Wanda Warlord", 3, 20, 45, 11));
                gameCharacters.Add(new Wizard("Yael", 3, 20, 45, 11));

                foreach (GameCharacter C in gameCharacters)
                {
                    Console.WriteLine("--------------------");
                    C.Play();
                }
            Console.WriteLine("\nDo you want to fight, or what? y/n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Ok then. Press enter to engage in battle. To the death.");
                Console.ReadLine();
                while (alive > 0)
                {
                    foreach (GameCharacter c in gameCharacters)
                    {
                        while (c.Strength > 0 && alive > 0)
                        {
                            int initialStrength = c.Strength;
                            //Console.WriteLine($"You will now be fighting {c.Name}, who has {c.Strength} life points.");
                            Console.WriteLine(" \n\t1. Rock\n\t2. Paper\n\t3. Scissors");
                            string RPScissorsChoice = Console.ReadLine();
                            result = Roll.RPScissors(RPScissorsChoice);
                            //Console.WriteLine(result);
                            {
                                if (result == "Win")
                                {
                                    alive += 10;
                                    c.Strength -= 15;
                                    if (c.Strength < 0)
                                    {
                                        c.Strength = 0;
                                    }
                                    Console.WriteLine("---------------------");
                                    Console.WriteLine($"\n     You've scored a hit! \n\nYou: {alive}   \n{c.Name} :{c.Strength}");
                                }
                                else if (result == "Lose")
                                {
                                    alive -= 3;
                                    c.Strength += 2;
                                    Console.WriteLine("---------------------");
                                    Console.WriteLine($"\n     You Lost that one! \n\nYou: {alive}   \n{c.Name} :{c.Strength}");

                                }
                                else
                                {
                                    Console.WriteLine("---------------------");
                                    Console.WriteLine($"\n     You tied. Keep up the fight!\n\nYou: {alive}   \n{c.Name} :{c.Strength}");
                                }

                            }
                        }

                    }
                    // Intentional never-ending-loop
                    string defeated = "You have defeated the enemies!";
                    string whoWantsSome = "Who wants some now???!!!";
                    if (alive > 0)
                    {
                        for (int i = 0; i < 25000; i++)
                        {
                            Console.WriteLine(defeated);
                        }
                        for (int i = 0; i < 25000; i++)
                        {
                            Console.WriteLine(whoWantsSome);
                        }
                    }

                  
                }
                if (alive < 0)
                {
                    for (int i = 0; i < 50000; i++)
                    {
                        Console.WriteLine("You Ded.");
                    }
                }

            }
            else
            {
                Console.WriteLine("Ok. Bye.");
            }
        }

    }
}
