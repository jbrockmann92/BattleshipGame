using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        public string name;
        public int score;
        public int bombXAxis;
        public int bombYAxis;
        string verticalOrHorizontal;
        int verticalChoice;
        int horizontalChoice;
        public int[,] battlefield = new int[20, 20];
        List<Ship> ships = new List<Ship>() { new Ship("Destroyer", 2), new Ship("Submarine", 3), new Ship("Battleship", 4), new Ship("Aircraft Carrier", 5) };


        //Working, but I still need to validate input and make sure that it doesn't allow the players to put ships on top of each other.
        //Would be cool to print off the board after each ship placement so the player has an idea of where they are.


        public void GetName()
        {
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
        }

        public void PlaceShips()
        {
                ShipLocations();
        }

        public void ShootBomb()
        {
            Console.WriteLine("Where would you like to shoot your bomb? Put the X-Axis first, then the Y-Axis");
            bombXAxis = int.Parse(Console.ReadLine());
            bombYAxis = int.Parse(Console.ReadLine());
        }

        public void CheckIfHit(int[,] battlefield)
        {
            this.battlefield = battlefield;
            if (battlefield[bombXAxis, bombYAxis] == 0)
            {
                Console.WriteLine("You missed!");
            }
            else if (battlefield[bombXAxis, bombYAxis] == 1)
            {
                Console.WriteLine("Hit!");
                score++;
                battlefield[bombXAxis, bombYAxis] = 0;
            }
            Console.ReadLine();
        }

        public void ShipLocations()
        {
            foreach (Ship ship in ships)
            {
                Console.WriteLine($"Would you like to place your {ship.name} vertically or horizontally?");
                verticalOrHorizontal = Console.ReadLine().ToLower();

                if (verticalOrHorizontal == "horizontal")
                {
                    HorizontalShipPlacement(ship);
                }

                else if (verticalOrHorizontal == "vertical")
                {
                    VerticalShipPlacement(ship);
                }
            }
        }

        //Change so that if the number goes negative ever they have to enter it again. That way it can't go off the edge of the map
        //Check also before placing each ship if there's a ship in the way

        public void HorizontalShipPlacement(Ship ship)
        {
            Console.WriteLine("Please enter the horizontal and vertical coordinates, 1-20, you'd like to place the right tip of the ship at");
            horizontalChoice = int.Parse(Console.ReadLine());
            verticalChoice = int.Parse(Console.ReadLine());
            TestAndPlaceHorizontal(ship);
        }

        public void VerticalShipPlacement(Ship ship)
        {
            Console.WriteLine("Please enter the horizontal and vertical coordinates, 1-20, you'd like to place the top of the ship at");
            horizontalChoice = int.Parse(Console.ReadLine());
            verticalChoice = int.Parse(Console.ReadLine());
            TestAndPlaceVertical(ship);
        }


        //The way I write this temporarily might mean that it won't test the first space. We'll see.
        //Not quite working with Destroyer again. Only doing one space because it decrements before it places the first one
        public void TestAndPlaceHorizontal(Ship ship)
        {
            if (horizontalChoice == 1)
            {
                Console.WriteLine("Sorry, there's already a ship there. Try again!");
                HorizontalShipPlacement(ship);
            }
            for (int i = 1; i < ship.length; i++)
            {
                battlefield[verticalChoice, horizontalChoice] = 1;
                battlefield[verticalChoice, horizontalChoice - 1] = 1;
                horizontalChoice--;
                if (horizontalChoice < 1)
                {
                    Console.WriteLine("Sorry, that's out of bounds. Try again!");
                    VerticalShipPlacement(ship);
                }
            }
        }

        public void TestAndPlaceVertical(Ship ship)
        {
            if (verticalChoice == 1)
            {
                Console.WriteLine("Sorry, there's already a ship there. Try again!");
                VerticalShipPlacement(ship);
            }
            for (int i = 1; i < ship.length; i++)
            {
                battlefield[verticalChoice, horizontalChoice] = 1;
                battlefield[verticalChoice - 1, horizontalChoice] = 1;
                verticalChoice++;
                if (verticalChoice > 20)
                {
                    Console.WriteLine("Sorry, that's out of bounds. Try again!");
                    VerticalShipPlacement(ship);
                }
            }
        }

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
    }
}
