using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Checkers
{
    public class Game
    {
        // Correct starting color turn
        public Color Turn = Color.Black;
        public Checker[,] Board = new Checker[8, 8];

        public Game()
        {
            // Correct placement of checkers
            for (int i = 0; i < 8; i += 2)
            {
                // Red Checkers
                Board[i + 1, 0] = new Checker(Color.Red);
                Board[i, 1] = new Checker(Color.Red);
                Board[i + 1, 2] = new Checker(Color.Red);

                //Black Checkers
                Board[i, 5] = new Checker(Color.Black);
                Board[i + 1, 6] = new Checker(Color.Black);
                Board[i, 7] = new Checker(Color.Black);
            }
        }

        public string Serialize()
        {
            string state = Turn.ToString() + "\n";
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (Board[x,y] != null)
                    {
                        Checker checker = Board[x, y];
                        state += $"{checker.Color},{checker.King},{x},{y}\n";
                    }
                }
            }
            return state;
        }
    }
}
