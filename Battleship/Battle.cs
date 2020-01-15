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

        List<Ship> ships = new List<Ship>();
        int[,] battlefield = new int[20, 20];
        Player playerOne = new Player();
        Player playerTwo = new Player();
       

        public void BeginBattle()
        {
            playerOne.PlaceShips();
            playerTwo.PlaceShips();

            playerOne.ShootBomb();
            playerOne.CheckIfHit(playerTwo.battlefield);
            playerTwo.ShootBomb();
            playerTwo.CheckIfHit(playerOne.battlefield);

            playerOne.PrintBattleField();
            playerTwo.PrintBattleField();
        }
        //I can just change the numbers in whichever place they put their ship to 1 or something. Ship.Length function or something

        //public void VerticalOrHorizontal()
        //{
        //    //WriteLine, then assign that value to either the x or y axis
        //    Console.WriteLine("Would you like to place your Destroyer vertically or horizontally?");
        //    verticalOrHorizontal = Console.ReadLine().ToLower();
        //}

        //Need to pass playerTwo's battlefield into this method before it will work. Then pass playerOne's
    }
}
