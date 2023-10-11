using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Display;

namespace Model
{
    public class Score
    {
        public int score = 0;
        Playground playground = new Playground();

        public void AddScore()
        {
            score += 10;
        }

        public void DisplayScore()
        {
            playground.DisplayScore(score);
        }
    }
}
