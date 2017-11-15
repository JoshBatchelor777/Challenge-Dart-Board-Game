using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Darts;

namespace ChallengeDartBoard
{
    // Score Class calls Darts and scores the Throw().
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int points = 0;

            if (dart.isTriple) points = dart.Score * 3;
            else if (dart.isDouble) points = dart.Score * 2;
            else points = dart.Score;

            if (dart.isTriple && dart.Score == 0) points = 50;
            else if (dart.Score == 0) points = 25;


            player.Score += points;
        }

    }
}
