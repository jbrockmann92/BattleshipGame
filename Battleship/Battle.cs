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
        //Set each value in battlefield to '.' at the moment
        int[,] battlefield = new int[20, 20];
        Player playerOne = new Player();
        Player playerTwo = new Player();


        //I think I need to assign the battlefield to the Player class, because each of them have one of their own
        public void PrintBattleField()
        {
            //place a series of numbers on the top and letters on the side, or just leave the user to enter [4, 2], etc.?
            int height = 20;
            int width = 20;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(battlefield[x, y] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        //I can just change the numbers in whichever place they put their ship to 1 or something. Ship.Length function or something

        //public void VerticalOrHorizontal()
        //{
        //    //WriteLine, then assign that value to either the x or y axis
        //    Console.WriteLine("Would you like to place your Destroyer vertically or horizontally?");
        //    verticalOrHorizontal = Console.ReadLine().ToLower();
        //}

        //public void PlaceShips()
        //{
        //    //Ship.Length function here
        //    //VerticalOrHorizontal()???
        //    //playerOne.battleship, playerTwo.submarine or something
        //    VerticalOrHorizontal();
        //    //Not exactly sure how to place the ships the right way
        //    if (verticalOrHorizontal == "horizontal")
        //    {
        //        Console.WriteLine("Please enter the horizontal and vertical lines, 1-20, you'd like to place the ship at");
        //        horizontalChoice = int.Parse(Console.ReadLine());
        //        verticalChoice = int.Parse(Console.ReadLine());
        //        battlefield[verticalChoice, horizontalChoice] = 1;
        //        battlefield[verticalChoice, horizontalChoice - 1] = 1;

        //        //Need to find how to put the length vertically or horizontally along the axis
        //    }
        //    else if (verticalOrHorizontal == "vertical")
        //    {
        //        Console.WriteLine("Please enter the horizontal and vertical lines, 1-20, you'd like to place the ship at");
        //        horizontalChoice = int.Parse(Console.ReadLine());
        //        verticalChoice = int.Parse(Console.ReadLine());
        //        battlefield[verticalChoice, horizontalChoice] = 1;
        //        battlefield[verticalChoice - 1, horizontalChoice] = 1;
        //        //Probably need a loop for the ship.Length to iterate and add to a variable or something. Doesn't work very well right now
        //    }
        //}

        //How can I get this to work for both, not just playerOne?
        public void CheckIfHit()
        {
            playerOne.ShootBomb();
            //Should be in Battle class?
            //Check if the location they hit 
            if (battlefield[playerOne.bombXAxis, playerOne.bombYAxis] == 0)
            {
                Console.WriteLine("You missed!");
            }
            else if (battlefield[playerOne.bombXAxis, playerOne.bombYAxis] == 1)
            {
                Console.WriteLine("Hit!");
                playerOne.score++;
            }
            Console.ReadLine();
        }
    }
}
