using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Darts;

namespace ChallengeDartBoard
{
    // Game Class holds the player variables
    public class Game
    {
        private Player p1;
        private Player p2;
        private Random _random; // using "_random" is just quicker and can be done when
        // "Random" is private.

        // This is what should happen every time a game is player (Game class is called).
        public Game(string player1Name, string player2Name)
        {
            // EVERY GAME: CREATE TWO NEW PLAYERS, RESET THEIR NAMES.
            p1 = new Player();
            p1.Name = player1Name;

            p2 = new Player();
            p2.Name = player2Name;

            // **AND** IT MUST BE PASSED INTO EVERY INSTANCE USING RANDOM VALUES.
            this._random = new Random();

        }

        public string Play()
        {
            // While neither players have reached 300, execute "playRound".
            while (p1.Score < 300 && p2.Score < 300)
            {
                // 3 dart throws for player 1, then player 2.
                playRound(p1);
                playRound(p2);
            }
            return displayerResults();
        }

        // Concatenate whatever is in result, and add on to it the score of the player who reached or surpassed 300 pts.
        private string displayerResults()
        {
            string result = String.Format("{0}: {1}:" + Environment.NewLine + "{2}: {3}" + Environment.NewLine,
                p1.Name, p1.Score, 
                p2.Name, p2.Score);

            return result += "Winner: " + 
                (p1.Score > p2.Score ? p1.Name : p2.Name);
        }

        // Iterate through each dart throw (via the for loop 1 to 3)
        // and execute Throw() each time.
        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(this._random);
                dart.Throw();

                Score.ScoreDart(player, dart);
                
            }
        }
    }
}
