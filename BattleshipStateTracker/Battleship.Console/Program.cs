using BattleshipStateTracker.Core;
using BattleshipStateTracker.Core.Entities;
using System;

namespace BattleshipStateTracker.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();


            //1. Create players and their respective game and firing boards
            Player p1 = new Player("Player 1");
            Player p2 = new Player("Player 2");

            game.Player1 = p1;
            game.Player2 = p2;

            //2. Add ships to the board
            p1.PlaceShips();
            p1.OutputBoards();

            p2.PlaceShips();
            p2.OutputBoards();

            //3. Take an attack at given position and report back whether it's a hit or a miss
            int row = 9;
            int col = 8;
            Console.WriteLine(p1.Name + " says: \"Firing shot at " + row.ToString() + ", " + col.ToString() + "\"");
            game.PlayRound(row, col);

            //4. Has the player lost?
            if (p2.HasLost)
                Console.WriteLine("Player 2 has lost");

            Console.ReadLine();

        }
    }
}
