using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Battle
    {
        //Instantiate 2 players here.
        //Probably place CheckIfHit() here too
        //Clear the console after each turn
        //Battle should have turns, not Player

        Player playerOne = new Player();
        Player playerTwo = new Player();


        public void BeginBattle()
        {
            playerOne.GetName();
            playerOne.PlaceShips();
            Console.WriteLine($"{playerOne.name}, here is your battlefield");
            playerOne.PrintBattleField();
            Console.ReadLine();
            Console.Clear();
            //battleships are all only two spaces long still. How to make them the right lengths?

            //something like:
            //if (Player chooses vertical)
            //    { 
            //    for (int i = 0; i < Battleship.length; i++)
            //    {
            //        (Playerchoice.yaxis -1) = 1
            //    }
            //}

            playerTwo.GetName();
            playerTwo.PlaceShips();
            Console.WriteLine($"{playerTwo.name}, here is your battlefield");
            playerTwo.PrintBattleField();
            Console.ReadLine();
            Console.Clear();

            while (playerOne.score < 15 && playerTwo.score < 15)
            {
                playerOne.ShootBomb();
                playerOne.CheckIfHit(playerTwo.battlefield);

                playerTwo.ShootBomb();
                playerTwo.CheckIfHit(playerOne.battlefield);

                //playerOne.PrintBattleField();
                //playerTwo.PrintBattleField();
            }

            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("Player One wins!");
            }
            else if (playerTwo.score > playerOne.score)
            {
                Console.WriteLine("Player Two wins!");
            }
        }
    }
}
