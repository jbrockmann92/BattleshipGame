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
        //Write 2D array here as well. Just a variable?


        int turn;
        //Set each value in battlefield to '.' at the moment
        int[,] battlefield = new int[20, 20];
        string verticalOrHorizontal;


        public void CreateBattleField()
        {
            //place a series of numbers on the top and letters on the side, or just leave the user to enter [4, 2], etc.?
            int height = 20;
            int width = 20;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(battlefield[x, y] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        //I can just change the numbers in whichever place they put their ship to 1 or something. Ship.Length function or something

        public void VerticalOrHorizontal()
        {
            //WriteLine, then assign that value to either the x or y axis
            Console.WriteLine("Would you like to place your Destroyer vertically or horizontally?");
            Console.ReadLine();

        }

        public void PlaceShips()
        {
            //Ship.Length function here
            //VerticalOrHorizontal()???
            //
            
        }

        public void CheckIfHit()
        {
            //Check if the location they hit 
        }

    }
}
