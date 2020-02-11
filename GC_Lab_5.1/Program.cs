using System;
using System.Collections.Generic;

namespace GC_Lab_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> playerList = new List<GameCharacter>();
            playerList.Add(new Warrior("Tnarg the Barbarian", 16, 9, "Axe"));
            playerList.Add(new Warrior("Kincaid the Fighter", 15, 16, "Longsword"));
            playerList.Add(new Warrior("Grant the Viking", 15, 16, "Spear"));
            playerList.Add(new Wizard("Lady Witherell the Wizard", 11, 18, 10, 5));
            playerList.Add(new Wizard("Pearl the Magician", 12, 17, 9, 4));


            Console.WriteLine("Welcome to the Worldof Dev.Buildcraft!");
            Console.WriteLine();

            foreach (GameCharacter player in playerList)
            {
                Console.Write(" - ");
                player.Play();
                Console.WriteLine();
            }
        }
    }
}
