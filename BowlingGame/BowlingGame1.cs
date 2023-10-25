using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class BowlingGame1
    {

        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public int Score {
            get {
                var score = 0;
                var rollIndex = 0;
                for (var frame = 0; frame < 10; frame++) {
                    if (rolls[rollIndex] == 10)
                    {
                        score += rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
                        rollIndex++;
                    }
                    else if (rolls[rollIndex] + rolls[rollIndex + 1] == 10)
                    {
                        score += rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
                        rollIndex += 2;
                    }
                    else
                    {
                        score += rolls[rollIndex] + rolls[rollIndex + 1];
                        rollIndex += 2;
                    }
                }

                return score;
            
            }
        
        
        }
        public void Roll(int pins) {
            rolls[currentRoll++] = pins;
        }
    }
}
